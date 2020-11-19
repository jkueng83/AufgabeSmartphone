using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeSmartphone.models
{
    public class Smartphone
    {
        private string name;
        private List<App> apps = new List<App>();

        public Smartphone()
        {
           // apps = new List<App>();
            name = "my phone";

            InstallStandardApps();
        }

         List<App> GetApps()
        {
            return apps;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        private void InstallStandardApps()
        {
            var calculator = new App("calculator", "1.0");
            apps.Add(calculator);

            var camera = new App("camera", "16.17");
            apps.Add(camera);
        }

        public List<string> AppNames()
        {
            List<string> names = new List<string>();

            foreach (var app in apps)
            {
                names.Add( app.Name);
            }
          
            return names;
        }

       

    }
}
