namespace AufgabeSmartphone
{
    partial class FormSmartPhone
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
            this.btShowApps = new System.Windows.Forms.Button();
            this.btShowGames = new System.Windows.Forms.Button();
            this.btStartApplication = new System.Windows.Forms.Button();
            this.btShowAll = new System.Windows.Forms.Button();
            this.tBoxAppName = new System.Windows.Forms.TextBox();
            this.tBoxVersion = new System.Windows.Forms.TextBox();
            this.btInstallApp = new System.Windows.Forms.Button();
            this.btInstallGame = new System.Windows.Forms.Button();
            this.tBoxGameDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSmartphoneName
            // 
            this.labelSmartphoneName.AutoSize = true;
            this.labelSmartphoneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSmartphoneName.Location = new System.Drawing.Point(36, 28);
            this.labelSmartphoneName.Name = "labelSmartphoneName";
            this.labelSmartphoneName.Size = new System.Drawing.Size(153, 20);
            this.labelSmartphoneName.TabIndex = 0;
            this.labelSmartphoneName.Tag = "";
            this.labelSmartphoneName.Text = "SmartphoneName";
            // 
            // lBoxApps
            // 
            this.lBoxApps.FormattingEnabled = true;
            this.lBoxApps.Location = new System.Drawing.Point(40, 104);
            this.lBoxApps.Name = "lBoxApps";
            this.lBoxApps.Size = new System.Drawing.Size(312, 147);
            this.lBoxApps.TabIndex = 1;
            this.lBoxApps.Tag = "";
            this.lBoxApps.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lBoxApps_MouseDoubleClick);
            // 
            // btShowApps
            // 
            this.btShowApps.Location = new System.Drawing.Point(146, 72);
            this.btShowApps.Name = "btShowApps";
            this.btShowApps.Size = new System.Drawing.Size(100, 23);
            this.btShowApps.TabIndex = 2;
            this.btShowApps.Text = "Show Apps";
            this.btShowApps.UseVisualStyleBackColor = true;
            this.btShowApps.Click += new System.EventHandler(this.btShowApps_Click);
            // 
            // btShowGames
            // 
            this.btShowGames.Location = new System.Drawing.Point(252, 72);
            this.btShowGames.Name = "btShowGames";
            this.btShowGames.Size = new System.Drawing.Size(100, 23);
            this.btShowGames.TabIndex = 3;
            this.btShowGames.Text = "Show Games";
            this.btShowGames.UseVisualStyleBackColor = true;
            this.btShowGames.Click += new System.EventHandler(this.btShowGames_Click);
            // 
            // btStartApplication
            // 
            this.btStartApplication.Location = new System.Drawing.Point(40, 279);
            this.btStartApplication.Name = "btStartApplication";
            this.btStartApplication.Size = new System.Drawing.Size(100, 23);
            this.btStartApplication.TabIndex = 4;
            this.btStartApplication.Text = "Start Application";
            this.btStartApplication.UseVisualStyleBackColor = true;
            this.btStartApplication.Click += new System.EventHandler(this.btStartApplication_Click);
            // 
            // btShowAll
            // 
            this.btShowAll.Location = new System.Drawing.Point(40, 72);
            this.btShowAll.Name = "btShowAll";
            this.btShowAll.Size = new System.Drawing.Size(100, 23);
            this.btShowAll.TabIndex = 5;
            this.btShowAll.Text = "Show All";
            this.btShowAll.UseVisualStyleBackColor = true;
            this.btShowAll.Click += new System.EventHandler(this.btShowAll_Click);
            // 
            // tBoxAppName
            // 
            this.tBoxAppName.Location = new System.Drawing.Point(4, 28);
            this.tBoxAppName.Name = "tBoxAppName";
            this.tBoxAppName.Size = new System.Drawing.Size(145, 20);
            this.tBoxAppName.TabIndex = 6;
            this.tBoxAppName.Text = "App or Game name";
            // 
            // tBoxVersion
            // 
            this.tBoxVersion.Location = new System.Drawing.Point(160, 28);
            this.tBoxVersion.Name = "tBoxVersion";
            this.tBoxVersion.Size = new System.Drawing.Size(145, 20);
            this.tBoxVersion.TabIndex = 7;
            this.tBoxVersion.Text = "Version";
            // 
            // btInstallApp
            // 
            this.btInstallApp.Location = new System.Drawing.Point(5, 80);
            this.btInstallApp.Name = "btInstallApp";
            this.btInstallApp.Size = new System.Drawing.Size(75, 23);
            this.btInstallApp.TabIndex = 8;
            this.btInstallApp.Text = "Install App";
            this.btInstallApp.UseVisualStyleBackColor = true;
            this.btInstallApp.Click += new System.EventHandler(this.btInstallApp_Click);
            // 
            // btInstallGame
            // 
            this.btInstallGame.Location = new System.Drawing.Point(6, 109);
            this.btInstallGame.Name = "btInstallGame";
            this.btInstallGame.Size = new System.Drawing.Size(75, 23);
            this.btInstallGame.TabIndex = 9;
            this.btInstallGame.Text = "Install Game";
            this.btInstallGame.UseVisualStyleBackColor = true;
            this.btInstallGame.Click += new System.EventHandler(this.btInstallGame_Click);
            // 
            // tBoxGameDescription
            // 
            this.tBoxGameDescription.Location = new System.Drawing.Point(5, 54);
            this.tBoxGameDescription.Name = "tBoxGameDescription";
            this.tBoxGameDescription.Size = new System.Drawing.Size(300, 20);
            this.tBoxGameDescription.TabIndex = 10;
            this.tBoxGameDescription.Text = "Game Description";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.btInstallGame);
            this.groupBox1.Controls.Add(this.tBoxVersion);
            this.groupBox1.Controls.Add(this.tBoxGameDescription);
            this.groupBox1.Controls.Add(this.tBoxAppName);
            this.groupBox1.Controls.Add(this.btInstallApp);
            this.groupBox1.Location = new System.Drawing.Point(40, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 144);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Install new App or Game";
            // 
            // FormSmartPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 503);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btShowAll);
            this.Controls.Add(this.btStartApplication);
            this.Controls.Add(this.btShowGames);
            this.Controls.Add(this.btShowApps);
            this.Controls.Add(this.lBoxApps);
            this.Controls.Add(this.labelSmartphoneName);
            this.Name = "FormSmartPhone";
            this.Text = "Smartphone";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSmartphoneName;
        private System.Windows.Forms.ListBox lBoxApps;
        private System.Windows.Forms.Button btShowApps;
        private System.Windows.Forms.Button btShowGames;
        private System.Windows.Forms.Button btStartApplication;
        private System.Windows.Forms.Button btShowAll;
        private System.Windows.Forms.TextBox tBoxAppName;
        private System.Windows.Forms.TextBox tBoxVersion;
        private System.Windows.Forms.Button btInstallApp;
        private System.Windows.Forms.Button btInstallGame;
        private System.Windows.Forms.TextBox tBoxGameDescription;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

