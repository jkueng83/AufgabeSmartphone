using AufgabeSmartphone.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProjectSmartphone
{
    public class Game : App
    {
        private string _description;

        public Game(string name, string version, string description) : base(name, version)
        {
            _description = description;          
        }

        public override string ToString()
        {
            return "App name: " + Name +
                " - Version: " + _version +
                " - Description: " + _description;
        }

         public override string StartApp()
        {
            return "The game: '" + Name + 
                "' is running in version: '" + _version + "'";
        }
    }
}
