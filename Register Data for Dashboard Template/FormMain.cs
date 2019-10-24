using Stimulsoft.Base;
using Stimulsoft.Report;
using System;
using System.IO;
using System.Windows.Forms;

namespace Register_Data_for_Dashboard_Template
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

        private void buttonJson_Click(object sender, EventArgs e)
        {
            textBoxLog.Clear();

            var report = StiReport.CreateNewDashboard();
            textBoxLog.Text += "New dashboard created\r\n";

            report.Load("Dashboards\\Dashboard.mrt");
            textBoxLog.Text += "Dashboard template loaded\r\n";

            var jsonBytes = File.ReadAllBytes("Dashboards\\Demo.json");
            textBoxLog.Text += "Load a JSON file\r\n";

            var json = StiJsonConnector.Get();
            var dataSet = json.GetDataSet(new StiJsonOptions(jsonBytes));
            textBoxLog.Text += "Get DataSet from JSON file\r\n";

            report.Dictionary.Databases.Clear();
            textBoxLog.Text += "Remove all connections from the dashboard template\r\n";

            report.RegData("Demo", "Demo", dataSet);
            textBoxLog.Text += "Register DataSet object\r\n";

            report.Show(false);
            textBoxLog.Text += "Show Dashboard\r\n";
        }
    }
}
