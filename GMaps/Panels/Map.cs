using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using GMaps.Database;
using GMaps.Model;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace GMaps.Panels
{
    public partial class Map : UserControl
    {
        private PointLatLng _currentPosition;
        private PointLatLng _currentDestination;

        private GMapOverlay _routes;
        private GMapOverlay _workingRoutes;

        private dynamic _working;
        private dynamic _parking;
        private string _filePath;
        public Map()
        {
            InitializeComponent();
            _filePath = @"..\..\..\error_log.txt";
        }

        /// <summary>
        /// Gets executed when the form loads.
        /// </summary>
        private void OnLoad(object sender, EventArgs e)
        {
            _routes = new GMapOverlay("routes");
            _workingRoutes = new GMapOverlay("Working Routes");
            _gMap.Overlays.Add(_routes);
            _gMap.Overlays.Add(_workingRoutes);
            _gMap.MapProvider = GoogleMapProvider.Instance; //Set the MapProvider.
            GMap.NET.GMaps.Instance.Mode = AccessMode.ServerAndCache; //AccesMode.
            _gMap.SetPositionByKeywords("The Hague");
            _gMap.DragButton = MouseButtons.Left;
            _gMap.ShowCenter = false; //Removes the red cross.
            CreateWorkingRoute();
            GetParkingspaces();
        }
        /// <summary>
        /// Get all parkingspaces from the dataset
        /// </summary>
        private void GetParkingspaces()
        {
            try
            {
                string json = new WebClient().DownloadString("https://geoservices.denhaag.nl/arcgis/rest/services/V2_0_Verkeer/Weg/MapServer/0/query?where=BORDTYPE_WAARDE%3D%27Algemene+gehandicaptenplaats%27&outFields=*&outSR=4326&f=json");
                _parking = JsonConvert.DeserializeObject<dynamic>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden tijdens het ophalen van de parkeerplekken");
                using (StreamWriter writer = new StreamWriter(_filePath, true))
                {
                    writer.WriteLine("Message : " + ex.Message + Environment.NewLine + ex.StackTrace
                    + Environment.NewLine + "Date : " + DateTime.Now.ToString() + Environment.NewLine);
                }
            }
        }
        /// <summary>
        /// Create markers in the overlay within the set radius from the user
        /// </summary>
        private void CreateMarkers()
        {
            try
            {
                foreach (dynamic item in _parking.features)
                {
                    if (item.geometry != null)
                    {
                        PointLatLng position = new PointLatLng((double)item.geometry.y, (double)item.geometry.x);
                        double markerDist = OpenStreetMapProvider.Instance.Projection.GetDistance(position, _currentDestination);
                        // Check if the distance is within the set radius
                        if (markerDist <= (Double.Parse(cmbMaxRadius.SelectedItem.ToString()) / 1000))
                        {
                            _routes.Markers.Add(new GMarkerGoogle(position, GMarkerGoogleType.blue)
                            { ToolTipText = (int)(markerDist * 1000) + " meter loopafstand" });
                        }
                    }
                }
                _gMap.OnMarkerClick += CreateRoute;
            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new StreamWriter(_filePath, true))
                {
                    writer.WriteLine("Message : " + ex.Message + Environment.NewLine + ex.StackTrace
                    + Environment.NewLine + "Date : " + DateTime.Now.ToString() + Environment.NewLine);
                }
            }
        }
        /// <summary>
        /// Create working routes from the JSON file to show the latest changes in the working routes. It will first analyse the data it receives and filter it on the essentiale data.
        /// After that it will set the data in a dictionary with a list of points. If it succeed it will after that show the data from the dictionary on the map.
        /// </summary>
        private void CreateWorkingRoute()
        {
            Dictionary<int, List<PointLatLng>> workingRoute = new Dictionary<int, List<PointLatLng>>();
            try
            {
                string json = new WebClient().DownloadString("https://services7.arcgis.com/b8OtZx5E96LVMxxJ/arcgis/rest/services/Wegwerkzaamheden2017_View/FeatureServer/0/query?where=1%3D1&outFields=*&outSR=4326&f=json");
                _working = JsonConvert.DeserializeObject<dynamic>(json);
                foreach (dynamic item in _working.features)
                {
                    // Only show the essentiale data
                    if (item.attributes.STATUS.ToString().Equals("actueel"))
                    {
                        foreach (var geometry in item.geometry.rings)
                        {
                            // Split the longitude and latitude
                            foreach (var points in geometry)
                            {
                                if (workingRoute.Keys.Contains((int)item.attributes.OBJECTID))
                                {
                                    workingRoute[(int)item.attributes.OBJECTID].Add(new PointLatLng((double)points[1], (double)points[0]));
                                }
                                else
                                {
                                    workingRoute.Add((int)item.attributes.OBJECTID, new List<PointLatLng> { new PointLatLng((double)points[1], (double)points[0]) });
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden tijdens het ophalen van de werkzaamheden");
                using (StreamWriter writer = new StreamWriter(_filePath, true))
                {
                    writer.WriteLine("Message : " + ex.Message + Environment.NewLine + ex.StackTrace
                    + Environment.NewLine + "Date : " + DateTime.Now.ToString() + Environment.NewLine);
                }
            }

            int i = 0;

            // Add all the working routes to the Overlay.
            foreach (KeyValuePair<int, List<PointLatLng>> item in workingRoute)
            {
                GMapRoute routeToAdd = new GMapRoute(item.Value, "WorkingRoute" + ++i);
                routeToAdd.Stroke = new Pen(Color.Red, 4);
                _workingRoutes.Routes.Add(routeToAdd);
            }
        }
        /// <summary>
        /// It will first clear all the markers and the circle from the map.
        /// After that it will generate a route from your current position to your chosen destination.
        /// </summary>
        /// <param name="item">The marker on which you click as user</param>
        /// <param name="e"></param>
        private void CreateRoute(GMapMarker item, MouseEventArgs e)
        {
            _routes.Clear();
            _gMap.OnMarkerClick -= CreateRoute;
            MapRoute route = OpenStreetMapProvider.Instance.GetRoute(_currentPosition, item.Position, false, false, 15);
            _routes.Markers.Add(new GMarkerGoogle(item.Position, GMarkerGoogleType.blue));
            _routes.Routes.Add(new GMapRoute(route.Points, "Route"));
        }
        /// <summary>
        /// Create the circle for the radius around the destination
        /// </summary>
        private void CreateCircle()
        {
            _routes.Clear();
            List<PointLatLng> radiusCircle = new List<PointLatLng>();
            double seg = Math.PI * 2 / 360;
            double aspect = 1.60;
            double radius = (Double.Parse(cmbMaxRadius.SelectedItem.ToString()) / 100000);
            // Set a point in the list for all the 360 degree in a circle
            for (int i = 0; i < 360; i++)
            {
                double theta = seg * i;
                double latitude = _currentDestination.Lat + Math.Cos(theta) * radius;
                double longitude = _currentDestination.Lng + Math.Sin(theta) * radius * aspect;

                radiusCircle.Add(new PointLatLng(latitude, longitude));
            }
            _routes.Polygons.Add(new GMapPolygon(radiusCircle, "Radius"));
        }

        /// <summary>
        /// Search the given location or show The Hague if non-given.
        /// Also checks if the given location exists.
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            GeoCoderStatusCode currentPositionCheck;
            GeoCoderStatusCode currentDestinationCheck;
            if (!string.IsNullOrWhiteSpace(tbDestination.Text) && !string.IsNullOrWhiteSpace(tbLocation.Text) && !string.IsNullOrWhiteSpace(cmbMaxRadius.Text))
            {
                // Get the points from the user input and checks if the location exists
                _currentPosition = GMapProviders.OpenStreetMap.GetPoint(tbLocation.Text, out currentPositionCheck).GetValueOrDefault();
                _currentDestination = GMapProviders.OpenStreetMap.GetPoint(tbDestination.Text, out currentDestinationCheck).GetValueOrDefault();
                if (currentPositionCheck == GeoCoderStatusCode.G_GEO_SUCCESS && currentDestinationCheck == GeoCoderStatusCode.G_GEO_SUCCESS)
                {
                    _gMap.SetPositionByKeywords(tbDestination.Text);
                    CreateCircle();
                    CreateMarkers();
                }
                else
                {
                    MessageBox.Show("Er is iets mis gegaan bij het maken van de route");
                }
            }
            else
            {
                _gMap.SetPositionByKeywords("The Hague");
                MessageBox.Show("De velden zijn incorrect ingevuld");
            }
        }
    }
}
