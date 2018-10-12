using Stimulsoft.Report;
using System;
using System.Windows.Forms;

namespace Edit_Dashboard_in_the_Designer
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

        private void buttonNew_Click(object sender, EventArgs e)
        {
            var report = StiReport.CreateNewDashboard();
            report.Design();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var report = GetTemplate();
            report.Design();
        }
    }
}
