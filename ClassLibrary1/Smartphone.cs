using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeSmartphone.models
{
    class Smartphone
    {
        private string _name;
        private List<App> _apps;

        public Smartphone()
        {
            this._apps = new List<App>();
            this._name = "my phone";

            InstallStandardApps();
        }



        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }


        private void InstallStandardApps()
        {
            var calculator = new App("calculator", "1.0");
            this._apps.Add(calculator);

            var camera = new App("polaroid digital", "16.17");
            this._apps.Add(camera);
        }

        public List<App> Apps { get { return this._apps; } }

    }
}
