using Stimulsoft.Report;
using System;
using System.IO;
using System.Windows.Forms;

namespace Export_Dashboard
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        private StiReport GetTemplate()
        {
            var report = new StiReport();
            report.Load("Dashboards\\Christmas.mrt");

            return report;
        }

        private void buttonPdf_Click(object sender, EventArgs e)
        {
            var report = GetTemplate();
            
            saveFileDialog.FileName = report.ReportName + ".pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var stream = new FileStream(saveFileDialog.FileName, FileMode.CreateNew);
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
                var stream = new FileStream(saveFileDialog.FileName, FileMode.CreateNew);
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
                var stream = new FileStream(saveFileDialog.FileName, FileMode.CreateNew);
                report.ExportDocument(StiExportFormat.ImagePng, stream);
                stream.Close();
            }
        }
    }
}
