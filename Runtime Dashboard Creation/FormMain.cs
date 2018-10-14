using Stimulsoft.Base.Drawing;
using Stimulsoft.Dashboard.Components;
using Stimulsoft.Dashboard.Components.Text;
using Stimulsoft.Report;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Runtime_Dashboard_Creation
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

        private StiReport CreateTemplate()
        {
            var report = new StiReport();
            report.Pages.Clear();

            var dashboard = new StiDashboard();
            report.Pages.Add(dashboard);

            var textElement = new StiTextElement();
            textElement.Left = 100;
            textElement.Top = 100;
            textElement.Width = 300;
            textElement.Height = 100;
            textElement.Text = "Sample Text";
            textElement.Border.Side = StiBorderSides.All;
            textElement.BackColor = Color.LightGray;

            dashboard.Components.Add(textElement);

            return report;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            var report = CreateTemplate();
            report.Show();
        }

        private void buttonDesign_Click(object sender, EventArgs e)
        {
            var report = CreateTemplate();
            report.Design();
        }
    }
}
