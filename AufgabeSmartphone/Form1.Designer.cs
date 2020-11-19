namespace AufgabeSmartphone
{
    partial class Form1
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
            this.labelSmartphoneName = new System.Windows.Forms.Label();
            this.lBoxApps = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelSmartphoneName
            // 
            this.labelSmartphoneName.AutoSize = true;
            this.labelSmartphoneName.Location = new System.Drawing.Point(37, 38);
            this.labelSmartphoneName.Name = "labelSmartphoneName";
            this.labelSmartphoneName.Size = new System.Drawing.Size(92, 13);
            this.labelSmartphoneName.TabIndex = 0;
            this.labelSmartphoneName.Tag = "";
            this.labelSmartphoneName.Text = "SmartphoneName";
            // 
            // lBoxApps
            // 
            this.lBoxApps.FormattingEnabled = true;
            this.lBoxApps.Location = new System.Drawing.Point(40, 104);
            this.lBoxApps.Name = "lBoxApps";
            this.lBoxApps.Size = new System.Drawing.Size(120, 95);
            this.lBoxApps.TabIndex = 1;
            this.lBoxApps.Tag = "";
            this.lBoxApps.SelectedIndexChanged += new System.EventHandler(this.lBoxApps_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 511);
            this.Controls.Add(this.lBoxApps);
            this.Controls.Add(this.labelSmartphoneName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSmartphoneName;
        private System.Windows.Forms.ListBox lBoxApps;
    }
}

