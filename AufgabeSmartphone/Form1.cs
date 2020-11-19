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
    public partial class Form1 : Form
    {
        Smartphone smartphone;

        Class1 c1 = new Class1();
        

        public Form1()
        {
            InitializeComponent();

            smartphone = new Smartphone();

            labelSmartphoneName.Text = smartphone.Name;
            UpdateAppListbox();
        }

        private void lBoxApps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateAppListbox()
        {
            lBoxApps.DataSource = smartphone.AppNames();

        }
    }
}
