using Stimulsoft.Report;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace Edit_Dashboard_in_the_Designer
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            var dict = new Dictionary<string, string>
            {
                {"Christmas","Dashboards\\Christmas.mrt"},
                {"Exchange Tenders","Dashboards\\Exchange Tenders.mrt"},
                {"Fast Food Lunch","Dashboards\\Fast Food Lunch.mrt"}
            };
            cmbTemplates.DataSource = new BindingSource(dict, null);
            cmbTemplates.DisplayMember = "Key";
            cmbTemplates.ValueMember = "Value";
        
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        //private StiReport GetTemplate()
        //{
        //    var report = new StiReport();
        //    report.Load("Dashboards\\Christmas.mrt");

        //    return report;
        //}

        private StiReport GetTemplate()
        {
            var report = new StiReport();
            if (cmbTemplates.SelectedValue != null)
            {
                string key = ((KeyValuePair<String,String>)cmbTemplates.SelectedItem).Key;
                string value = ((KeyValuePair<String, String>)cmbTemplates.SelectedItem).Value;
                //MessageBox.Show(key + " , " + value);               
                report.Load(value);                              
            }
            else
            {
                report.Load("Dashboards\\Christmas.mrt");
            }
            return report;
        }

        private void cmbTemplates_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Cursor = Cursors.Default;
            
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            var report = StiReport.CreateNewDashboard();
            report.Design();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (cmbTemplates.Text.Length == 0)
            {
                MessageBox.Show("Please select a template from drop down list.", "Edit Dashboard In Designer-FormMain");
                cmbTemplates.Focus();
                return;
            }
            else
            {
                var report = GetTemplate();
                report.Design();
            }           
        }

        //private void buttonEdit_Click(object sender, EventArgs e)
        //{          
        //    var report = GetTemplate();
        //    report.Design();
        //}
    }
}
