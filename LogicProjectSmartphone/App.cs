using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeSmartphone.models
{
   public class App
    {        
        internal string _version;        

        public App( string name, string version)
        {
            Name = name;
            _version = version;
           
        }  
       
        public string Name { get; set; }

        public override string ToString()
        {
            return "App name: " + Name + " - Version: " + _version;
        }

        public virtual string StartApp()
        {
            return "The application: '" + Name + "' is running in version: '" + _version + "'";
        }
    }
}
