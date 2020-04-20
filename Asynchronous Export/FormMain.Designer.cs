namespace Asynchronous_Export
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
            this.buttonImage = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.buttonPdf = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonHTML = new System.Windows.Forms.Button();
            this.buttonWord = new System.Windows.Forms.Button();
            this.cmbTemplates = new System.Windows.Forms.ComboBox();
            this.lblTemplates = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonImage
            // 
            this.buttonImage.Location = new System.Drawing.Point(642, 19);
            this.buttonImage.Margin = new System.Windows.Forms.Padding(2);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Size = new System.Drawing.Size(294, 65);
            this.buttonImage.TabIndex = 7;
            this.buttonImage.Text = "Async Export to Image";
            this.buttonImage.UseVisualStyleBackColor = true;
            this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Location = new System.Drawing.Point(330, 19);
            this.buttonExcel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(294, 65);
            this.buttonExcel.TabIndex = 6;
            this.buttonExcel.Text = "Async Export to Excel";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // buttonPdf
            // 
            this.buttonPdf.Location = new System.Drawing.Point(20, 19);
            this.buttonPdf.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPdf.Name = "buttonPdf";
            this.buttonPdf.Size = new System.Drawing.Size(292, 65);
            this.buttonPdf.TabIndex = 5;
            this.buttonPdf.Text = "Async Export to PDF";
            this.buttonPdf.UseVisualStyleBackColor = true;
            this.buttonPdf.Click += new System.EventHandler(this.buttonPdf_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(18, 154);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 31);
            this.labelStatus.TabIndex = 8;
            // 
            // buttonHTML
            // 
            this.buttonHTML.Location = new System.Drawing.Point(197, 109);
            this.buttonHTML.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHTML.Name = "buttonHTML";
            this.buttonHTML.Size = new System.Drawing.Size(292, 65);
            this.buttonHTML.TabIndex = 9;
            this.buttonHTML.Text = "Async Export to HTML";
            this.buttonHTML.UseVisualStyleBackColor = true;
            this.buttonHTML.Click += new System.EventHandler(this.buttonHTML_Click);
            // 
            // buttonWord
            // 
            this.buttonWord.Location = new System.Drawing.Point(511, 109);
            this.buttonWord.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWord.Name = "buttonWord";
            this.buttonWord.Size = new System.Drawing.Size(292, 65);
            this.buttonWord.TabIndex = 10;
            this.buttonWord.Text = "Async Export to Word";
            this.buttonWord.UseVisualStyleBackColor = true;
            this.buttonWord.Click += new System.EventHandler(this.buttonWord_Click);
            // 
            // cmbTemplates
            // 
            this.cmbTemplates.FormattingEnabled = true;
            this.cmbTemplates.Location = new System.Drawing.Point(391, 375);
            this.cmbTemplates.Name = "cmbTemplates";
            this.cmbTemplates.Size = new System.Drawing.Size(233, 33);
            this.cmbTemplates.TabIndex = 11;
            this.cmbTemplates.SelectedIndexChanged += new System.EventHandler(this.cmbTemplates_SelectedIndexChanged);
            // 
            // lblTemplates
            // 
            this.lblTemplates.AutoSize = true;
            this.lblTemplates.Location = new System.Drawing.Point(325, 309);
            this.lblTemplates.Name = "lblTemplates";
            this.lblTemplates.Size = new System.Drawing.Size(362, 25);
            this.lblTemplates.TabIndex = 12;
            this.lblTemplates.Text = "Select a template to Edit Dashboard.";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 521);
            this.Controls.Add(this.lblTemplates);
            this.Controls.Add(this.cmbTemplates);
            this.Controls.Add(this.buttonWord);
            this.Controls.Add(this.buttonHTML);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonImage);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonPdf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Asynchronous Export";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonImage;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.Button buttonPdf;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonHTML;
        private System.Windows.Forms.Button buttonWord;
        private System.Windows.Forms.ComboBox cmbTemplates;
        private System.Windows.Forms.Label lblTemplates;
    }
}

