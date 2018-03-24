namespace GMaps.Panels
{
    partial class Map
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCurrentLocation = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this._gMap = new GMap.NET.WindowsForms.GMapControl();
            this.cmbMaxRadius = new System.Windows.Forms.ComboBox();
            this.lblMaxRadius = new System.Windows.Forms.Label();
            this.lblMeter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentLocation
            // 
            this.lblCurrentLocation.AutoSize = true;
            this.lblCurrentLocation.Location = new System.Drawing.Point(6, 16);
            this.lblCurrentLocation.Name = "lblCurrentLocation";
            this.lblCurrentLocation.Size = new System.Drawing.Size(80, 13);
            this.lblCurrentLocation.TabIndex = 4;
            this.lblCurrentLocation.Text = "Huidige locatie:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(6, 62);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(57, 13);
            this.lblDestination.TabIndex = 5;
            this.lblDestination.Text = "Destinatie:";
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(6, 32);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(181, 20);
            this.tbLocation.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(36, 154);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Zoeken 🔍";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(6, 78);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(181, 20);
            this.tbDestination.TabIndex = 1;
            // 
            // _gMap
            // 
            this._gMap.Bearing = 0F;
            this._gMap.CanDragMap = true;
            this._gMap.Dock = System.Windows.Forms.DockStyle.Right;
            this._gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this._gMap.GrayScaleMode = false;
            this._gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this._gMap.LevelsKeepInMemmory = 5;
            this._gMap.Location = new System.Drawing.Point(199, 0);
            this._gMap.MarkersEnabled = true;
            this._gMap.MaxZoom = 18;
            this._gMap.MinZoom = 8;
            this._gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.ViewCenter;
            this._gMap.Name = "_gMap";
            this._gMap.NegativeMode = false;
            this._gMap.PolygonsEnabled = true;
            this._gMap.RetryLoadTile = 0;
            this._gMap.RoutesEnabled = true;
            this._gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this._gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this._gMap.ShowTileGridLines = false;
            this._gMap.Size = new System.Drawing.Size(589, 394);
            this._gMap.TabIndex = 5;
            this._gMap.TabStop = false;
            this._gMap.Zoom = 13D;
            // 
            // cmbMaxRadius
            // 
            this.cmbMaxRadius.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaxRadius.FormattingEnabled = true;
            this.cmbMaxRadius.Items.AddRange(new object[] {
            "250",
            "500",
            "750",
            "1000"});
            this.cmbMaxRadius.Location = new System.Drawing.Point(6, 127);
            this.cmbMaxRadius.Name = "cmbMaxRadius";
            this.cmbMaxRadius.Size = new System.Drawing.Size(142, 21);
            this.cmbMaxRadius.TabIndex = 2;
            // 
            // lblMaxRadius
            // 
            this.lblMaxRadius.AutoSize = true;
            this.lblMaxRadius.Location = new System.Drawing.Point(6, 111);
            this.lblMaxRadius.Name = "lblMaxRadius";
            this.lblMaxRadius.Size = new System.Drawing.Size(88, 13);
            this.lblMaxRadius.TabIndex = 6;
            this.lblMaxRadius.Text = "Max loopafstand:";
            // 
            // lblMeter
            // 
            this.lblMeter.AutoSize = true;
            this.lblMeter.Location = new System.Drawing.Point(154, 130);
            this.lblMeter.Name = "lblMeter";
            this.lblMeter.Size = new System.Drawing.Size(33, 13);
            this.lblMeter.TabIndex = 7;
            this.lblMeter.Text = "meter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GMaps.Properties.Resources.Legend;
            this.pictureBox1.Location = new System.Drawing.Point(9, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 178);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMeter);
            this.Controls.Add(this.lblMaxRadius);
            this.Controls.Add(this.cmbMaxRadius);
            this.Controls.Add(this.lblCurrentLocation);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbDestination);
            this.Controls.Add(this._gMap);
            this.Location = new System.Drawing.Point(147, 66);
            this.Name = "Map";
            this.Size = new System.Drawing.Size(788, 394);
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentLocation;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbDestination;
        private GMap.NET.WindowsForms.GMapControl _gMap;
        private System.Windows.Forms.ComboBox cmbMaxRadius;
        private System.Windows.Forms.Label lblMaxRadius;
        private System.Windows.Forms.Label lblMeter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
