using Stimulsoft.Dashboard.Components;
using Stimulsoft.Dashboard.Viewer;
using Stimulsoft.Dashboard.Viewer.Controls;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class DashboardDemoForm : Form
    {
        public DashboardDemoForm()
        {
            InitializeComponent();
            
            new StiDashboard();

            Icon = StiOptions.Viewer.Windows.ViewerIcon ?? StiAppIcons.GetIcon();
            Report = report;

            FillReportsList();
            listBoxReports.SelectedItem = listBoxReports.Items.Cast<object>().FirstOrDefault();
        }

        #region Fields
        private List<StiReport> reports = new List<StiReport>();
        #endregion

        #region Properties
        public StiDashboardViewerControl ViewerControl { get; set; }

        public List<StiDashboard> Dashboards => Report?.Pages.OfType<StiDashboard>().Where(d => d.Enabled).ToList();

        /// <summary>
        /// Gets or sets viewed report.
        /// </summary>
        private StiReport report;
        [Browsable(false)]
        public virtual StiReport Report
        {
            get
            {
                return report;
            }
            set
            {
                report = value;

                if (value != null)
                {
                    Text = StiOptions.Viewer.GetViewerTitleWithMask(value.ReportAlias.Length == 0 ? null : value.ReportAlias);
                    Build();
                }
            }
        }
        #endregion

        #region Handlers
        private void Reports_SelectedIndexChanged(object sender, EventArgs e)
        {
            var report = reports[listBoxReports.SelectedIndex];
            Report = report;
        }
        #endregion

        #region Methods
        private void FillReportsList()
        {
            var dir = new DirectoryInfo("Templates");
            if (!dir.Exists) return;

            reports.Clear();
            listBoxReports.Items.Clear();
            

            var files = dir.GetFiles("*.mrt");
            foreach (var file in files)
            {
                var report = new StiReport();
                report.Load(file.FullName);

                reports.Add(report);
                listBoxReports.Items.Add(Path.GetFileNameWithoutExtension(file.FullName));
            }
        }

        public void Build()
        {
            if (report == null || !Dashboards.Any()) return;

            if (ViewerControl != null && Controls.Contains(ViewerControl))
                Controls.Remove(ViewerControl);

            ViewerControl = new StiDashboardViewerControl(Report);
            ViewerControl.Dock = DockStyle.Fill;
            Controls.Add(ViewerControl);
            Controls.SetChildIndex(ViewerControl, 0);
        }
        #endregion

        private void buttonEditDashboard_Click(object sender, EventArgs e)
        {
            var report = reports[listBoxReports.SelectedIndex];
            var originalReportClone = report.Clone() as StiReport;
            originalReportClone.Design();
        }
    }
}