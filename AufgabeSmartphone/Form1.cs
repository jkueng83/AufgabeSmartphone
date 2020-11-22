using AufgabeSmartphone.models;

using LogicProjectSmartphone;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AufgabeSmartphone
{
    public partial class FormSmartPhone : Form
    {
        Smartphone smartphone;

        public FormSmartPhone()
        {
            InitializeComponent();

            smartphone = new Smartphone("my phone");

            labelSmartphoneName.Text = smartphone.Name;
            UpdateListboxAppsWihtAllAppsAndGAmes();
        }

        private void UpdateListboxAppsWihtAllAppsAndGAmes()
        {
            lBoxApps.DataSource = smartphone.AllApps.OrderBy(app => app.Name)
                .Select(app => app.Name).ToList();

            btStartApplication.Text = "Start Application";
        }

        private void UpdateListboxAppsWihtApps()
        {
            //lBoxApps.DataSource = smartphone.Apps.OrderBy(app => app.Name).OfType(App).Select(app => app.Name).ToList();

            //    Select(app => app.GetType.Equals(App))
            //    .Select(app => app.Name).ToList();

            lBoxApps.DataSource = smartphone.Apps.OrderBy(app => app.Name)
                .Select(app => app.Name).ToList();

            btStartApplication.Text = "Start App";
        }

        private void UpdateListboxAppsWihtGames()
        {
            lBoxApps.DataSource = smartphone.Games.OrderBy(game => game.Name)
                .Select(game => game.Name).ToList();

            btStartApplication.Text = "Start Game";
        }

        private void btShowAll_Click(object sender, EventArgs e)
        {
            UpdateListboxAppsWihtAllAppsAndGAmes(); 
        }

        private void btShowApps_Click(object sender, EventArgs e)
        {
            UpdateListboxAppsWihtApps();
        }

        private void btShowGames_Click(object sender, EventArgs e)
        {
            UpdateListboxAppsWihtGames();
        }

        private void btStartApplication_Click(object sender, EventArgs e)
        {
            string selectedApp = lBoxApps.SelectedItem.ToString();

            StartApplication(selectedApp);
        }

        private void StartApplication(string appName)
        {
            MessageBox.Show(smartphone.StartApp(appName));
        }

        private void lBoxApps_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedApp = lBoxApps.SelectedItem.ToString();

            StartApplication(selectedApp);
        }

        private void btInstallApp_Click(object sender, EventArgs e)
        {
            App newApp = new App(tBoxAppName.Text, tBoxVersion.Text);
            smartphone.InstallApp(newApp);
            UpdateListboxAppsWihtAllAppsAndGAmes();
        }

        private void btInstallGame_Click(object sender, EventArgs e)
        {
            Game newGame= new Game(tBoxAppName.Text, tBoxVersion.Text, 
                tBoxGameDescription.Text);
            smartphone.InstallApp(newGame);
            UpdateListboxAppsWihtAllAppsAndGAmes();
        }
    }
}
