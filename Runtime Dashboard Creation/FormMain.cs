using Stimulsoft.Base.Drawing;
using Stimulsoft.Dashboard.Components;
using Stimulsoft.Dashboard.Components.Table;
using Stimulsoft.Dashboard.Components.Text;
using Stimulsoft.Data.Engine;
using Stimulsoft.Report;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Runtime_Dashboard_Creation
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);

            InitializeComponent();
        }

        private StiReport CreateTemplate()
        {
            var report = StiReport.CreateNewDashboard();
            var dashboard = report.Pages[0] as StiDashboard;

            var data = new DataSet();
            data.ReadXml("Data/Demo.xml");

            report.RegData(data);
            report.Dictionary.Synchronize();

            var tableElement = new StiTableElement();
            tableElement.Left = 0;
            tableElement.Top = 0;
            tableElement.Width = 700;
            tableElement.Height = 500;
            tableElement.Border.Side = StiBorderSides.All;
            tableElement.BackColor = Color.LightGray;
            tableElement.Name = "Example";

            var dataBase = new StiDimensionColumn();
            dataBase.Expression = "Products.ProductID";
            tableElement.Columns.Add(dataBase);

            var dataBase1 = new StiDimensionColumn();
            dataBase1.Expression = "Products.ProductName";
            tableElement.Columns.Add(dataBase1);

            var dataBase2 = new StiDimensionColumn();
            dataBase2.Expression = "Products.UnitPrice";
            tableElement.Columns.Add(dataBase2);

            var filter1 = new StiDataFilterRule();
            filter1.Condition = StiDataFilterCondition.BeginningWith;
            filter1.Path = "Products.ProductID";
            filter1.Value = "1";
            tableElement.DataFilters.Add(filter1);

            var filter2 = new StiDataFilterRule();
            filter2.Condition = StiDataFilterCondition.EndingWith;
            filter2.Path = "Products.UnitPrice";
            filter2.Value = "1";
            tableElement.DataFilters.Add(filter2);

            dashboard.Components.Add(tableElement);

            return report;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            var dashboard = CreateTemplate();
            dashboard.Show();
        }

        private void buttonDesign_Click(object sender, EventArgs e)
        {
            var dashboard = CreateTemplate();
            dashboard.Design();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            var dashboard = CreateTemplate();
            dashboard.ExportDocument(StiExportFormat.Excel2007, "Dashboard.xlsx");
            MessageBox.Show("The dashboard is saved as a file '/bin/Dashboard.xlsx'");
        }
    }
}
