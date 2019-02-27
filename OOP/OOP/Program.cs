using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Felder
            //Person p1 = new Person(); // Instanzieren 
            //p1.Vorname = "Tom";
            //p1.Nachname = "Ate";
            //p1.Alter = 50;
            //p1.Kontostand = 500m;
            //p1.Geschlecht = true; // Männlich

            //Person p2 = new Person();
            //p2.Vorname = "Anna";
            //p2.Nachname = "Nass";

            //Console.WriteLine(p1.Vorname +  " " + p1.Nachname);

            //p1.Kontostand = -2000000m; 
            #endregion

            #region Variante "Java"
            //Person p1 = new Person();
            //p1.AlterSetzen(12);
            //p1.AlterSetzen(55);
            //p1.AlterSetzen(255);

            //Console.WriteLine(p1.AlterAuslesen()); 
            #endregion

            #region Properties
            //Person p1 = new Person();
            //p1.Geburtstag();
            //p1.Geburtstag();
            //p1.Geburtstag();
            //p1.Geburtstag();

            //p1.Vorname = "Tom";
            //p1.Nachname = "Ate"; 
            //Console.WriteLine(p1.Alter);
            #endregion

            #region Konstruktor
            //Person p1 = new Person(500,"Max", "Mustermann"); // Standard-Konstruktor

            //p1 = null;
            //// Garbage Collector direkt ansteuern:
            //// GC.Collect 
            #endregion

            #region Überladen

            //Taschenrechner t1 = new Taschenrechner();
            //int erg  = t1.Add(12, 5);
            //int erg2  = t1.Add(12, 5, 8); 
            #endregion

            #region Polymorphie
            //Grafik g1 = new Grafik("Rot");
            //Kreis k1 = new Kreis("Gelb", 20);
            //Rechteck r1 = new Rechteck("Grün", 5, 12);

            //g1.Zeichnen();
            //k1.Zeichnen();
            //r1.Zeichnen();

            //// Polymorphie -> Vielgestaltigkeit
            //// "Ein Objekt der Subklasse(Kreis, etc) kann wie ein Objekt der Basisklasse (Grafik) verwendet werden"

            //Console.WriteLine("----------------------- Überschreiben -----------------------");

            //Grafik g2 = new Kreis("Orange", 40);
            //g2.Zeichnen();

            //Kreis k2 = (Kreis)g2; // wir wissen, dass da ein Kreis dahinter liegt
            //Console.WriteLine(k2.Radius);

            //Console.WriteLine("----------------------- Verstecken -----------------------");
            //Grafik g3 = new Rechteck("Violett", 50, 30);
            //g3.Zeichnen();

            //Console.WriteLine("----------------------- Anwendungsfall -----------------------");

            //Grafik[] alleGrafiken = new Grafik[4];
            //alleGrafiken[0] = g1; // Grafik
            //alleGrafiken[1] = k1; // Kreis
            //alleGrafiken[2] = r1; // Rechteck
            //alleGrafiken[3] = k2; // Kreis

            //foreach (Grafik g in alleGrafiken)
            //{
            //    // Techniken für die Frage "Was bin ich nun wirklich ?"
            //    // 1) Console.WriteLine(g.GetType());
            //    // 2) is
            //    if(g is Rechteck r)// C#7 -> wenn g ein rechteck ist, konvertiere es zu "r"
            //    { 
            //        //Rechteck r = (Rechteck)g; // mit der Variante oben spart man sich diese Zeile ;)
            //        Console.WriteLine("Ich bin in wirklichkeit ein Rechteck:");
            //    }
            //    g.Zeichnen();
            //}

            //// DRY - Dont repeat yourself 
            #endregion

            #region Abstrakte Klasse
            //Girokonto g1 = new Girokonto();
            //Jugendkonto j1 = new Jugendkonto();

            //Konto k1 = new Konto(); // darf nicht verwendet werden 
            #endregion

            #region Statische Klasse
            //SpezialTaschenrechner t = new SpezialTaschenrechner();
            //int erg = t.Add(12, 4);

            //SpezialTaschenrechner 
            #endregion

            #region Partielle Klasse
            //Girokonto g = new Girokonto();
            #endregion
            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }

    partial class Girokonto
    {
        public void Demo()
        {

        }

        public void MachWas()
        {

        }
    }
}
