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
            this.SuspendLayout();
            // 
            // buttonDesigner
            // 
            this.buttonDesigner.Location = new System.Drawing.Point(10, 10);
            this.buttonDesigner.Margin = new System.Windows.Forms.Padding(1);
            this.buttonDesigner.Name = "buttonDesigner";
            this.buttonDesigner.Size = new System.Drawing.Size(178, 34);
            this.buttonDesigner.TabIndex = 3;
            this.buttonDesigner.Text = "Open Dashboard Designer";
            this.buttonDesigner.UseVisualStyleBackColor = true;
            this.buttonDesigner.Click += new System.EventHandler(this.buttonDesigner_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 271);
            this.Controls.Add(this.buttonDesigner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Add a Custom Function";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDesigner;
    }
}