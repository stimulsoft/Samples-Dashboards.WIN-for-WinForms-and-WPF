namespace Export_Dashboard
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
            this.buttonExcel = new System.Windows.Forms.Button();
            this.buttonPdf = new System.Windows.Forms.Button();
            this.buttonImage = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.cmbTemplates = new System.Windows.Forms.ComboBox();
            this.lblTemplates = new System.Windows.Forms.Label();
            this.buttonHtml = new System.Windows.Forms.Button();
            this.buttonWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExcel
            // 
            this.buttonExcel.Location = new System.Drawing.Point(330, 19);
            this.buttonExcel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(294, 65);
            this.buttonExcel.TabIndex = 3;
            this.buttonExcel.Text = "Export to Excel";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // buttonPdf
            // 
            this.buttonPdf.Location = new System.Drawing.Point(20, 19);
            this.buttonPdf.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPdf.Name = "buttonPdf";
            this.buttonPdf.Size = new System.Drawing.Size(292, 65);
            this.buttonPdf.TabIndex = 2;
            this.buttonPdf.Text = "Export to PDF";
            this.buttonPdf.UseVisualStyleBackColor = true;
            this.buttonPdf.Click += new System.EventHandler(this.buttonPdf_Click);
            // 
            // buttonImage
            // 
            this.buttonImage.Location = new System.Drawing.Point(642, 19);
            this.buttonImage.Margin = new System.Windows.Forms.Padding(2);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Size = new System.Drawing.Size(294, 65);
            this.buttonImage.TabIndex = 4;
            this.buttonImage.Text = "Export to Image";
            this.buttonImage.UseVisualStyleBackColor = true;
            this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Title = "Save Dashboard";
            // 
            // cmbTemplates
            // 
            this.cmbTemplates.FormattingEnabled = true;
            this.cmbTemplates.Location = new System.Drawing.Point(361, 237);
            this.cmbTemplates.Name = "cmbTemplates";
            this.cmbTemplates.Size = new System.Drawing.Size(233, 33);
            this.cmbTemplates.TabIndex = 8;
            // 
            // lblTemplates
            // 
            this.lblTemplates.AutoSize = true;
            this.lblTemplates.Location = new System.Drawing.Point(292, 191);
            this.lblTemplates.Name = "lblTemplates";
            this.lblTemplates.Size = new System.Drawing.Size(362, 25);
            this.lblTemplates.TabIndex = 9;
            this.lblTemplates.Text = "Select a template to Edit Dashboard.";
            // 
            // buttonHtml
            // 
            this.buttonHtml.Location = new System.Drawing.Point(178, 104);
            this.buttonHtml.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHtml.Name = "buttonHtml";
            this.buttonHtml.Size = new System.Drawing.Size(292, 65);
            this.buttonHtml.TabIndex = 10;
            this.buttonHtml.Text = "Export to Html";
            this.buttonHtml.UseVisualStyleBackColor = true;
            this.buttonHtml.Click += new System.EventHandler(this.buttonHtml_Click);
            // 
            // buttonWord
            // 
            this.buttonWord.Location = new System.Drawing.Point(487, 104);
            this.buttonWord.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWord.Name = "buttonWord";
            this.buttonWord.Size = new System.Drawing.Size(292, 65);
            this.buttonWord.TabIndex = 11;
            this.buttonWord.Text = "Export to Word";
            this.buttonWord.UseVisualStyleBackColor = true;
            this.buttonWord.Click += new System.EventHandler(this.buttonWord_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 521);
            this.Controls.Add(this.buttonWord);
            this.Controls.Add(this.buttonHtml);
            this.Controls.Add(this.lblTemplates);
            this.Controls.Add(this.cmbTemplates);
            this.Controls.Add(this.buttonImage);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonPdf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.Button buttonPdf;
        private System.Windows.Forms.Button buttonImage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ComboBox cmbTemplates;
        private System.Windows.Forms.Label lblTemplates;
        private System.Windows.Forms.Button buttonHtml;
        private System.Windows.Forms.Button buttonWord;
    }
}

