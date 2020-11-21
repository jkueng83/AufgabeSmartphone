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
        private string name;

        private List<App> _allApps = new List<App>();
        private List<App> _apps = new List<App>();

        private List<App> _games = new List<App>();

        public Smartphone()
        {
            // apps = new List<App>();
            name = "my phone";

            InstallStandardApps();
            InstallStandardGames();

            SelectGames();
        }

        //private List<App> GetApps()
        //{
        //    return apps;
        //}

        public List<App> AllApps
        {
            get { return _allApps; }
        }
        public List<App> Apps
        {
            get
            {
                SelectApps();
                return _apps;
            }
        }

        //private List<Game> SelectGames()
        //{
        //    //List<Game> games = apps.Where(app => Game.Equals  app.GetType().Equals(Game); // .OfType<App>();
        //   // var game = new Game("to get type of Game", "23", "");
        //    //var list = from app in _apps where (app.Type == "all") select app;
        //   // List<Game> games = from app in _apps where (app.Type == "all") select app;
        //    return games;
        //}
        public List<App> Games
        {
            get
            {
                SelectGames();
                return _games;
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
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
            _apps.Add(app);
            _allApps.Add(app);
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
            AddGame(snake);


            var needForSpeed = new Game("Need for Speed", "2018", "Need for Speed (kurz NFS; " +
                "englisch für „Bedürfnis nach Geschwindigkeit“) ist eine Autorennspiel-Serie von " +
                "Electronic Arts. Die Serie ist bekannt dafür, dass sie schon früh real existierende " +
                "Serienwagen und Konzeptfahrzeuge mit Herstellerlizenz ins Spiel einband. In anderen " +
                "Rennspielen waren bis dahin meist fiktive Fahrzeuge zu sehen.");
            AddGame(needForSpeed);

        }

        private void AddGame(App game)
        {
            _allApps.Add(game);
            _games.Add(game);
        }

        public List<string> AppNames()
        {
            List<string> names = new List<string>();

            foreach (var app in _apps)
            {
                names.Add(app.Name);
            }

            return names;
        }

        public string StartApp(string appName)
        {
            foreach (var app in _allApps)
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
            App a = new App("to compare", "");
            Game game = new Game("to compare ", "", "");

            bool isEqual = app.GetType() == a.GetType();
            if (app.GetType() == game.GetType())
            {
                AddGame(app);
            }
            else if (app.GetType() == a.GetType())
            {
                AddApp(app);
            }
            else
            {
                Console.WriteLine("no app");
            }
        }

        private void SelectGames()
        {

            Game gameToCompare = new Game("to compare ", "", "");

            //List<Game> games = _allApps.Select(app => (app.GetType() == game.GetType()));

            var gamesTest = _allApps.Select(app => app.GetType() == gameToCompare.GetType()).
                Where(app => app.GetType() == gameToCompare.GetType());
            var games = from g in _allApps
                        where g.GetType() == gameToCompare.GetType()
                        select g;

            

            //bool isEqual = app.GetType() == a.GetType();
            //if (app.GetType() == game.GetType())
            //{
            //    AddGame(app);
            //}
            //else if (app.GetType() == a.GetType())
            //{
            //    AddApp(app);
            //}
            //else
            //{
            //    Console.WriteLine("no app");
            //}
        }

        private void SelectApps()
        {
            App appToCompare = new App("to compare", "");


            //List<Game> games = _allApps.Select(app => (app.GetType() == game.GetType()));


            var apps = from g in _allApps
                       where g.GetType() == appToCompare.GetType()
                       select g;


        }
    }
}
