using Stimulsoft.Base;
using Stimulsoft.Report;
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace Register_Data_for_Dashboard_Template
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            //Ken Huynh, issue 2_Register Dashboard, 3/25/2020
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
            buttonJson.Visible = false;
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

            if (cmbTemplates.SelectedValue != null)
            {
                string key = ((KeyValuePair<String, String>)cmbTemplates.SelectedItem).Key;
                string value = ((KeyValuePair<String, String>)cmbTemplates.SelectedItem).Value;              
                report.Load(value);
            }
            else
            {
                report.Load("Dashboards\\Dashboard.mrt");
            }
            //report.Load("Dashboards\\Dashboard.mrt");
            
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

        //Ken Huynh, issue 2_Register Dashboard, 3/25/2020
        private void cmbTemplates_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Cursor = Cursors.Default;
            if ((String)cmbTemplates.SelectedValue != "")
            {
                string key = ((KeyValuePair<String, String>)cmbTemplates.SelectedItem).Key;
                string value = ((KeyValuePair<String, String>)cmbTemplates.SelectedItem).Value;
                buttonJson.Visible = true;
            }
            else
            {
                buttonJson.Visible = false;
            }
        }

        
    }
}
