using Stimulsoft.Base.Drawing;
using Stimulsoft.Controls.Wpf.Helpers;
using Stimulsoft.Dashboard.Components;
using Stimulsoft.Dashboard.Viewer;
using Stimulsoft.Report;
using Stimulsoft.Report.Dashboard.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Demo
{
    public partial class DashboardDemoForm : Form
    {
        public DashboardDemoForm()
        {
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);

            InitializeComponent();
            
            new StiDashboard();

            Icon = StiOptions.Viewer.Windows.ViewerIcon ?? StiAppIcons.GetIcon();
            Report = report;

            FillReportsList();
            listBoxDashboards.SelectedItem = listBoxDashboards.Items.Cast<object>().FirstOrDefault();
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
            var report = reports[listBoxDashboards.SelectedIndex];

            var dashboard = report.Pages[0] as StiDashboard;
            this.BackColor = dashboard != null ? StiDashboardStyleHelper.GetDashboardBackColor(dashboard, true) : SystemColors.Control;
            listBoxDashboards.Colors.ForeColor = dashboard != null ? StiDashboardStyleHelper.GetForeColor(dashboard) : Color.DimGray;
            listBoxDashboards.Colors.HotForeColor = StiColorUtils.Dark(listBoxDashboards.Colors.ForeColor, 60);
            listBoxDashboards.Colors.GlyphColor = listBoxDashboards.Colors.ForeColor;
            listBoxDashboards.Colors.HotGlyphColor = listBoxDashboards.Colors.HotForeColor;

            Report = report;
        }
        #endregion

        #region Methods
        private void FillReportsList()
        {
            var dir = new DirectoryInfo("Templates");
            if (!dir.Exists) return;

            reports.Clear();
            listBoxDashboards.Items.Clear();
            
            var files = dir.GetFiles("*.mrt");
            foreach (var file in files)
            {
                var report = new StiReport();
                report.Load(file.FullName);

                reports.Add(report);
                listBoxDashboards.Items.Add(" " + Path.GetFileNameWithoutExtension(file.FullName).Remove(0, 9));
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
            var report = reports[listBoxDashboards.SelectedIndex];
            var originalReportClone = report.Clone() as StiReport;
            originalReportClone.Design();
        }
    }
}