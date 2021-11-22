namespace Showing_a_Dashboard_in_the_Viewer
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonPanel = new System.Windows.Forms.Button();
            this.panelViewer = new System.Windows.Forms.Panel();
            this.buttonDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.Location = new System.Drawing.Point(165, 10);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(1);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(147, 34);
            this.buttonPanel.TabIndex = 1;
            this.buttonPanel.Text = "Show Viewer in the Panel";
            this.buttonPanel.UseVisualStyleBackColor = true;
            this.buttonPanel.Click += new System.EventHandler(this.buttonPanel_Click);
            // 
            // panelViewer
            // 
            this.panelViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelViewer.Location = new System.Drawing.Point(10, 54);
            this.panelViewer.Margin = new System.Windows.Forms.Padding(1);
            this.panelViewer.Name = "panelViewer";
            this.panelViewer.Size = new System.Drawing.Size(964, 516);
            this.panelViewer.TabIndex = 2;
            // 
            // buttonDialog
            // 
            this.buttonDialog.Location = new System.Drawing.Point(10, 10);
            this.buttonDialog.Margin = new System.Windows.Forms.Padding(1);
            this.buttonDialog.Name = "buttonDialog";
            this.buttonDialog.Size = new System.Drawing.Size(146, 34);
            this.buttonDialog.TabIndex = 0;
            this.buttonDialog.Text = "Show Viewer Dialog";
            this.buttonDialog.UseVisualStyleBackColor = true;
            this.buttonDialog.Click += new System.EventHandler(this.buttonDialog_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.panelViewer);
            this.Controls.Add(this.buttonDialog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Showing a Dashboard in the Viewer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPanel;
        private System.Windows.Forms.Panel panelViewer;
        private System.Windows.Forms.Button buttonDialog;
    }
}

