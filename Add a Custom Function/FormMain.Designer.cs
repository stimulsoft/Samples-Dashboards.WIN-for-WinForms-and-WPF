namespace Add_a_Custom_Function
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
            this.buttonDesigner = new System.Windows.Forms.Button();
            this.lblTemplates = new System.Windows.Forms.Label();
            this.cmbTemplates = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonDesigner
            // 
            this.buttonDesigner.Location = new System.Drawing.Point(20, 19);
            this.buttonDesigner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDesigner.Name = "buttonDesigner";
            this.buttonDesigner.Size = new System.Drawing.Size(356, 65);
            this.buttonDesigner.TabIndex = 3;
            this.buttonDesigner.Text = "Open Dashboard Designer";
            this.buttonDesigner.UseVisualStyleBackColor = true;
            this.buttonDesigner.Click += new System.EventHandler(this.buttonDesigner_Click);
            // 
            // lblTemplates
            // 
            this.lblTemplates.AutoSize = true;
            this.lblTemplates.Location = new System.Drawing.Point(461, 19);
            this.lblTemplates.Name = "lblTemplates";
            this.lblTemplates.Size = new System.Drawing.Size(362, 25);
            this.lblTemplates.TabIndex = 9;
            this.lblTemplates.Text = "Select a template to Edit Dashboard.";
            // 
            // cmbTemplates
            // 
            this.cmbTemplates.FormattingEnabled = true;
            this.cmbTemplates.Location = new System.Drawing.Point(516, 51);
            this.cmbTemplates.Name = "cmbTemplates";
            this.cmbTemplates.Size = new System.Drawing.Size(233, 33);
            this.cmbTemplates.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 521);
            this.Controls.Add(this.cmbTemplates);
            this.Controls.Add(this.lblTemplates);
            this.Controls.Add(this.buttonDesigner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a Custom Function";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDesigner;
        private System.Windows.Forms.Label lblTemplates;
        private System.Windows.Forms.ComboBox cmbTemplates;
    }
}