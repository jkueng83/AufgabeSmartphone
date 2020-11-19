using AufgabeSmartphone.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AufgabeSmartphone
{
    static class Program
    {
        /// <summary>
        /// 
        /* 
         * Erstelle eine Klasse Smartphone, die unteranderem eine Liste an Apps enthält. 
         * Erstelle zusätzlich eine Klasse App mit einigen Properties, die alle Apps haben 
         * und eine dritte Klasse Game, welche von App erbt und selbst noch ein paar Properties hat. 
         * Überschreibe zusätzlich die ToString() Methoden beider Klassen. 
         * Schreibe auch eine Start Methode in App, die Game überschreibt. 
         * Erstelle einige Apps und Spiele die du in die Liste des Smartphones gibst. 
         * Der Nutzer soll nun mit den Befehlen:
         * 
         * Start: <appname>
         * 
         * Startet die genannte App (oder Spiel)
         *
         * Filter: <Apps/Games>
         *
         * Zeigt entweder alle Apps oder alle Spiele an. 
         * Wenn der Nutzer nur Apps sehen will soll er auch nur Apps sehen, keine Spiele. 
         * Die Filterung sollst du mit LINQ durchführen (bietet Methoden für dieses Szenario). 
         * Das Leerzeichen in den Befehlen zwischen dem : und dem Argument ist Absicht und soll auch so implementiert werden.
         *
         * Start:       <appname>
         *
         * Dieser Befehl soll ebenfalls gültig sein.
         */
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
