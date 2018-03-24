using GMaps.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMaps.Database
{
    class ReportController : DatabaseController
    {
        /// <summary>
        /// Insert the given report
        /// </summary>
        /// <param name="report">The data to import in the database</param>
        public void InsertReport(Report report)
        {
            try
            {
                connection.Open();
                string query = $"INSERT INTO report(firstname, lastname, insertion, message, category, email) VALUES('{report.FirstName}', '{report.LastName}', '{report.Insertion}', '{report.Message}', '{report.Category}', '{report.Email}')";

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("Message : " + ex.Message + Environment.NewLine + ex.StackTrace
                    + Environment.NewLine + "Date : " + DateTime.Now.ToString() + Environment.NewLine);
                }
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Get all the reports from the database and insert it in a list
        /// </summary>
        /// <returns></returns>
        public List<Report> GetReportList()
        {
            List<Report> reportList = new List<Report>();

            try
            {
                connection.Open();
                string query = @"SELECT * FROM report";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Report report = new Report();
                    report.Id = Convert.ToInt32(reader["id"].ToString());
                    report.FirstName = reader["firstname"].ToString();
                    report.LastName = reader["lastname"].ToString();
                    //  check if insertion is not NULL
                    if (!reader.IsDBNull(2))
                    {
                        report.Insertion = reader["insertion"].ToString();
                    }
                    report.Email = reader["email"].ToString();
                    report.Category = reader["category"].ToString();
                    report.Message = reader["message"].ToString();

                    reportList.Add(report);
                }
            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("Message : " + ex.Message + Environment.NewLine + ex.StackTrace
                    + Environment.NewLine + "Date : " + DateTime.Now.ToString() + Environment.NewLine);
                }
            }
            finally
            {
                connection.Close();
            }
            return reportList;
        }
    }
}
