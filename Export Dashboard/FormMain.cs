using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Export_Dashboard
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            /// Ken Huynh, 4/10/2020, using dictionnary to store key/value pair of template
            /// the name of template file is a key and its value is the path of that file
            var dict = new Dictionary<string, string>
            {
                {"Select a template",""},
                {"Christmas","Dashboards\\Christmas.mrt"},
                {"Exchange Tenders","Dashboards\\Exchange Tenders.mrt"},
                {"Fast Food Lunch","Dashboards\\Fast Food Lunch.mrt"}
            };
            cmbTemplates.DataSource = new BindingSource(dict, null);
            cmbTemplates.DisplayMember = "Key";
            cmbTemplates.ValueMember = "Value";
            cmbTemplates.SelectedIndexChanged += new System.EventHandler(cmbTemplates_SelectedIndexChanged);
            buttonPdf.Visible = false;
            buttonExcel.Visible = false;
            buttonImage.Visible = false;
            buttonHtml.Visible = false;
            buttonWord.Visible = false;

            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        // Original code, Ken Huynh, 4/5/2020
        //private StiReport GetTemplate()
        //{
        //    var report = StiReport.CreateNewDashboard();
        //    report.Load("Dashboards\\Christmas.mrt");

        //    return report;
        //}

        ///Ken Huynh, 4/5/2020, Issue 3
        ///Modified this function to load the file from the comboBox
        private StiReport GetTemplate()
        {
            var report = StiReport.CreateNewDashboard();
            ///Get the value of the selected item from comboBox
            ///and load this value, file path
            if (cmbTemplates.SelectedValue != null)
            {
                string key = ((KeyValuePair<String, String>)cmbTemplates.SelectedItem).Key;
                string value = ((KeyValuePair<String, String>)cmbTemplates.SelectedItem).Value;
                report.Load(value);
            }
            /// default is Dashboard.mrt
            else
            {
                report.Load("Dashboards\\Dashboard.mrt");
            }

            return report;
        }

        private void buttonPdf_Click(object sender, EventArgs e)
        {
            var report = GetTemplate();
            
            saveFileDialog.FileName = report.ReportName + ".pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var stream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                report.ExportDocument(StiExportFormat.Pdf, stream);
                stream.Close();
            }
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            var report = GetTemplate();

            saveFileDialog.FileName = report.ReportName + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var stream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                report.ExportDocument(StiExportFormat.Excel2007, stream);
                stream.Close();
            }
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            var report = GetTemplate();

            saveFileDialog.FileName = report.ReportName + ".png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var stream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                report.ExportDocument(StiExportFormat.ImagePng, stream);
                stream.Close();
            }
        }

        /// Ken Huynh, issue 3, hide the buttons till the users select one item in the comboBox
        /// This self intuitive logic guides users to do the exporting tasks.
        private void cmbTemplates_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Cursor = Cursors.Default;
            if ((String)cmbTemplates.SelectedValue != "")
            {
                string key = ((KeyValuePair<String, String>)cmbTemplates.SelectedItem).Key;
                string value = ((KeyValuePair<String, String>)cmbTemplates.SelectedItem).Value;
                buttonPdf.Visible = true;
                buttonExcel.Visible = true;
                buttonImage.Visible = true;
                buttonHtml.Visible = true;
                buttonWord.Visible = true;
            }
            else
            {
                buttonPdf.Visible = false;
                buttonExcel.Visible = false;
                buttonImage.Visible = false;
                buttonHtml.Visible = false;
                buttonWord.Visible = false;
            }
        }
        /// Ken Huynh, 4/10/2020, this function generates a report in HTML format and 
        /// open a dialog for users to select the location and name of the file
        private void buttonHtml_Click(object sender, EventArgs e)
        {
            var report = GetTemplate();

            saveFileDialog.FileName = report.ReportName + ".html";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var stream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                report.ExportDocument(StiExportFormat.Html, stream);
                stream.Close();
            }
        }
        /// Ken Huynh, 4/10/2020, this function generates a report in Word 2017 format and 
        /// open a dialog for users to select the location and name of the file
        private void buttonWord_Click(object sender, EventArgs e)
        {
            var report = GetTemplate();

            saveFileDialog.FileName = report.ReportName + ".docx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var stream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                report.ExportDocument(StiExportFormat.Word2007, stream);
                stream.Close();
            }
        }
    }
}
