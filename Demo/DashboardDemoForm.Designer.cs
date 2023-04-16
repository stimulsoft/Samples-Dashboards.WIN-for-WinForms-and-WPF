namespace Demo
{
    partial class DashboardDemoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardDemoForm));
            this.listBoxDashboards = new Stimulsoft.Dashboard.Viewer.Controls.ListBox.StiListBox();
            this.panelReports = new System.Windows.Forms.Panel();
            this.buttonEditDashboard = new System.Windows.Forms.Button();
            this.panelReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxDashboards
            // 
            this.listBoxDashboards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDashboards.BackColor = System.Drawing.Color.Transparent;
            this.listBoxDashboards.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxDashboards.ForeColor = System.Drawing.Color.DimGray;
            this.listBoxDashboards.IsTransparent = true;
            this.listBoxDashboards.Location = new System.Drawing.Point(12, 67);
            this.listBoxDashboards.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxDashboards.Name = "listBoxDashboards";
            this.listBoxDashboards.Size = new System.Drawing.Size(520, 787);
            this.listBoxDashboards.TabIndex = 0;
            this.listBoxDashboards.SelectedIndexChanged += new System.EventHandler(this.Reports_SelectedIndexChanged);
            // 
            // panelReports
            // 
            this.panelReports.Controls.Add(this.buttonEditDashboard);
            this.panelReports.Controls.Add(this.listBoxDashboards);
            this.panelReports.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelReports.Location = new System.Drawing.Point(10, 10);
            this.panelReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelReports.Name = "panelReports";
            this.panelReports.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.panelReports.Size = new System.Drawing.Size(532, 867);
            this.panelReports.TabIndex = 0;
            // 
            // buttonEditDashboard
            // 
            this.buttonEditDashboard.Location = new System.Drawing.Point(12, 8);
            this.buttonEditDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditDashboard.Name = "buttonEditDashboard";
            this.buttonEditDashboard.Size = new System.Drawing.Size(520, 46);
            this.buttonEditDashboard.TabIndex = 1;
            this.buttonEditDashboard.Text = "Edit Dashboard";
            this.buttonEditDashboard.UseVisualStyleBackColor = true;
            this.buttonEditDashboard.Click += new System.EventHandler(this.buttonEditDashboard_Click);
            // 
            // DashboardDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 887);
            this.Controls.Add(this.panelReports);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1584, 867);
            this.Name = "DashboardDemoForm";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.Text = "Dashboards Demo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelReports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Stimulsoft.Dashboard.Viewer.Controls.ListBox.StiListBox listBoxDashboards;
        private System.Windows.Forms.Panel panelReports;
        private System.Windows.Forms.Button buttonEditDashboard;
    }
}