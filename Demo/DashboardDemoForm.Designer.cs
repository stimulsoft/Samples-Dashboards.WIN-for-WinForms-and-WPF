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
            this.listBoxDashboards.BackColor = System.Drawing.Color.White;
            this.listBoxDashboards.ForeColor = System.Drawing.Color.DimGray;
            this.listBoxDashboards.Location = new System.Drawing.Point(6, 35);
            this.listBoxDashboards.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxDashboards.Name = "listBoxDashboards";
            this.listBoxDashboards.Size = new System.Drawing.Size(260, 409);
            this.listBoxDashboards.TabIndex = 0;
            this.listBoxDashboards.SelectedIndexChanged += new System.EventHandler(this.Reports_SelectedIndexChanged);
            // 
            // panelReports
            // 
            this.panelReports.Controls.Add(this.buttonEditDashboard);
            this.panelReports.Controls.Add(this.listBoxDashboards);
            this.panelReports.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelReports.Location = new System.Drawing.Point(5, 5);
            this.panelReports.Margin = new System.Windows.Forms.Padding(2);
            this.panelReports.Name = "panelReports";
            this.panelReports.Padding = new System.Windows.Forms.Padding(6);
            this.panelReports.Size = new System.Drawing.Size(266, 451);
            this.panelReports.TabIndex = 0;
            // 
            // buttonEditDashboard
            // 
            this.buttonEditDashboard.Location = new System.Drawing.Point(6, 4);
            this.buttonEditDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditDashboard.Name = "buttonEditDashboard";
            this.buttonEditDashboard.Size = new System.Drawing.Size(260, 24);
            this.buttonEditDashboard.TabIndex = 1;
            this.buttonEditDashboard.Text = "Edit Dashboard";
            this.buttonEditDashboard.UseVisualStyleBackColor = true;
            this.buttonEditDashboard.Click += new System.EventHandler(this.buttonEditDashboard_Click);
            // 
            // DashboardDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 461);
            this.Controls.Add(this.panelReports);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(810, 500);
            this.Name = "DashboardDemoForm";
            this.Padding = new System.Windows.Forms.Padding(5);
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