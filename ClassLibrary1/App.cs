using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeSmartphone.models
{
    class App
    {
        private string _name;
        private string _version;

        public App( string name, string version)
        {
            this._name = name;
            this._version = version;
        }
    }
}
