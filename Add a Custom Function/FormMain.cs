using Stimulsoft.Data.Extensions;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Add_a_Custom_Function
{
    public partial class FormMain : Form
    {
        public class MyClass
        {
            public static decimal MySum(object value)
            {
                if (!ListExt.IsList(value))
                    return Stimulsoft.Base.Helpers.StiValueHelper.TryToDecimal(value);

                return Stimulsoft.Data.Functions.Funcs.SkipNulls(ListExt.ToList(value))
                    .TryCastToDecimal()
                    .Sum();
            }
        }

        public FormMain()
        {
            InitializeComponent();

            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);

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

            AddCustomFunction();
        }

        private void AddCustomFunction()
        {
            StiFunctions.AddFunction(
                "My Category", "MySum", "description",
                typeof(MyClass),
                typeof(decimal),
                "Calculates a sum of the specified set of values.",
                new[] { typeof(object) },
                new[] { "values" },
                new[] { "A set of values" }).UseFullPath = false;
        }

        ///Modified by Ken Huynh, 4/19/2020, adding more templates and comboBox 
        
        private void buttonDesigner_Click(object sender, EventArgs e)
        {
            var report = StiReport.CreateNewDashboard();
            if (cmbTemplates.SelectedValue != null)
            {
                string key = ((KeyValuePair<String, String>)cmbTemplates.SelectedItem).Key;
                string value = ((KeyValuePair<String, String>)cmbTemplates.SelectedItem).Value;
                //MessageBox.Show(key + " , " + value);               
                report.Load(value);
            }
            else
            {
                report.Load("Dashboards\\Christmas.mrt");
            }           

            report.Design();
        }

        ///Original code, Ken Huynh, 4/19/2020
        //private void buttonDesigner_Click(object sender, EventArgs e)
        //{
        //    var report = StiReport.CreateNewDashboard();
        //    report.Load("Dashboards\\Christmas.mrt");

        //    report.Design();
        //}
    }
}
