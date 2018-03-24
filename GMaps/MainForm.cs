using GMaps.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMaps
{
    public partial class MainForm : Form
    {
        Map _map = new Map();
        Report _report = new Report();
        Panels.Help _help = new Panels.Help();
        public MainForm()
        {
            InitializeComponent();
        }
        private void OnLoad(object sender, EventArgs e)
        {
            this.Controls.Add(_help);
            this.Controls.Add(_report);
            this.Controls.Add(_map);
            _map.BringToFront();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            btnReport.Enabled = false;
            btnHelp.Enabled = true;
            btnHome.Enabled = true;
            _report.BringToFront();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            btnReport.Enabled = true;
            btnHelp.Enabled = false;
            btnHome.Enabled = true;
            _help.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnReport.Enabled = true;
            btnHelp.Enabled = true;
            btnHome.Enabled = false;
            _map.BringToFront();
        }
    }
}
