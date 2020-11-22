using LogicProjectSmartphone;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeSmartphone.models
{
    public class Smartphone
    {
        private string _name;
        private List<App> _appsAndGames = new List<App>();        

        public Smartphone(string name)
        {           
            _name = name;

            InstallStandardApps();
            InstallStandardGames();

            GetAllGames();
        }        

        public List<App> AllApps
        {
            get { return _appsAndGames; }
        }

        public List<App> Apps
        {
            get { return GetAllApps(); }
        }

        public List<App> Games
        {
            get { return GetAllGames(); }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private void InstallStandardApps()
        {
            var calculator = new App("calculator", "1.0");
            AddApp(calculator);

            var camera = new App("camera", "16.17");
            AddApp(camera);

            var sonso = new App("sonos", "1.0");
            AddApp(sonso);

            var gitHub = new App("gitHub", "2.0");
            AddApp(gitHub);
        }

        private void AddApp(App app)
        {            
            _appsAndGames.Add(app);
        }

        private void InstallStandardGames()
        {
            var snake = new Game("Snake", "V20.15", " Snake (englisch für Schlange) ist ein " +
                "Computerspielklassiker, bei dem eine sich gerade oder rechtwinklig bewegende " +
                "Schlange durch ein Spielfeld gesteuert wird. Ziel des Spieles ist, die als Futter " +
                "angebotenen zufällig erscheinenden „Happen“ aufzunehmen und Hindernissen, " +
                "einschließlich des eigenen Schlangenkörpers, auszuweichen. Während die Schlange " +
                "mit jedem Happen wächst, wird das Manövrieren bei zunehmend vollerem Spielfeld – " +
                "und bei evtl. schnellerem Grundtakt – immer schwieriger.");
            AddApp(snake);

            var needForSpeed = new Game("Need for Speed", "2018", "Need for Speed (kurz NFS; " +
                "englisch für „Bedürfnis nach Geschwindigkeit“) ist eine Autorennspiel-Serie von " +
                "Electronic Arts. Die Serie ist bekannt dafür, dass sie schon früh real existierende " +
                "Serienwagen und Konzeptfahrzeuge mit Herstellerlizenz ins Spiel einband. In anderen " +
                "Rennspielen waren bis dahin meist fiktive Fahrzeuge zu sehen.");
            AddApp(needForSpeed);
        }              

        public string StartApp(string appName)
        {
            foreach (var app in _appsAndGames)
            {
                if (app.Name == appName)
                {
                    return app.StartApp();
                }
            }

            return "App is not installed";
        }

        public void InstallApp(App app)
        {           
                AddApp(app);            
        }

        private List<App> GetAllGames()
        {
            Game gameToCompare = new Game("to compare ", "", "");
                      
            var collectionOfAllGames = _appsAndGames.Select(app => app).
                Where(app => app.GetType() == gameToCompare.GetType()).ToList();//Jetzt hab ich es gefunden: ToList gibt eine Liste zurück!

            return collectionOfAllGames;            
        }

        private List<App> GetAllApps()
        {
            App appToCompare = new App("to compare", "");

            List<App> collectionOfAllApps = _appsAndGames.Select(app => app).Where(app => app.GetType() == appToCompare.GetType()).ToList();

            return collectionOfAllApps;
        }
    }
}
