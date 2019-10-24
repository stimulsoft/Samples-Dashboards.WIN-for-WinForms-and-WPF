using Stimulsoft.Report;
using System;
using System.Windows.Forms;

namespace Asynchronous_Export
{
    public partial class FormMain : Form
    {
        public StiReport Report { get; set; }

        public FormMain()
        {
            InitializeComponent();

            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);

            Report = GetTemplate();
        }

        private StiReport GetTemplate()
        {
            var report = StiReport.CreateNewDashboard();
            report.Load("Dashboards\\Christmas.mrt");

            return report;
        }

        private async void buttonPdf_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = Report.ReportName + ".pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                labelStatus.Text = "Exporting...";

                await Report.ExportDocumentAsync(StiExportFormat.Pdf, saveFileDialog.FileName);

                labelStatus.Text = "";
            }
        }

        private async void buttonExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = Report.ReportName + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                labelStatus.Text = "Exporting...";

                await Report.ExportDocumentAsync(StiExportFormat.Excel2007, saveFileDialog.FileName);

                labelStatus.Text = "";
            }
        }

        private async void buttonImage_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = Report.ReportName + ".png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                labelStatus.Text = "Exporting...";

                await Report.ExportDocumentAsync(StiExportFormat.ImagePng, saveFileDialog.FileName);

                labelStatus.Text = "";
            }
        }
    }
}
