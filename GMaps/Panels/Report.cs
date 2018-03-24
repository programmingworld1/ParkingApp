using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using GMaps.Database;
using System.IO;
using CsvHelper;

namespace GMaps.Panels
{
    public partial class Report : UserControl
    {
        ReportController _reportController;

        public Report()
        {
            InitializeComponent();
            _reportController = new ReportController();
        }
        /// <summary>
        /// Check if all the fields are correct and if that is true it ask the insert method to insert the new data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            bool _fieldsCorrect = true;
            epError.Clear();
            // Check all the fields if it is correct
            foreach (Control item in Controls.Cast<Control>())
            {
                if (item is TextBox || item is ComboBox)
                {
                    if (string.IsNullOrWhiteSpace(item.Text) && item != tbInsertion)
                    {
                        _fieldsCorrect = false;
                        epError.SetError(item, "Dit veld is incorrect ingevuld");
                    }
                }
            }
            // Check if it is a real email
            if (!Regex.IsMatch(tbEmail.Text, @"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"))
            {
                _fieldsCorrect = false;
                epError.SetError(tbEmail, "Email is incorrect");
            }

            if (_fieldsCorrect)
            {
                Model.Report report = new Model.Report();
                report.FirstName = tbFirstname.Text;
                report.LastName = tbLastname.Text;
                report.Message = tbMessage.Text;
                report.Category = cmbCategory.Text;
                report.Insertion = tbInsertion.Text;
                report.Email = tbEmail.Text;
                _reportController.InsertReport(report);
                foreach (Control item in Controls.Cast<Control>())
                {
                    if (item is TextBox || item is ComboBox)
                    {
                        item.Text = null;
                    }
                }
                MessageBox.Show("Uw bericht is verzonden en zal zo spoedig mogelijk in handeling worden genomen");
                WriteCSV();
            }
        }
        /// <summary>
        /// Make a CSV file from all the current reports
        /// </summary>
        private void WriteCSV()
        {
            if (File.Exists(@"../../Report.csv"))
            {
                File.Delete(@"../../Report.csv");
            }
            using (TextWriter writer = new StreamWriter(@"../../Report.csv", true))
            {
                CsvWriter csv = new CsvWriter(writer);
                csv.Configuration.Encoding = Encoding.UTF8;
                List<Model.Report> reportList = new List<Model.Report>();
                reportList = _reportController.GetReportList();
                csv.WriteRecords(reportList);
                //writer.Flush();
            }
        }
    }
}
