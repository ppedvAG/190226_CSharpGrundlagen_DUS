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

            #region Parameter

            //int[] zahlen = { 12, 3, 5 };

            //var erg = Parameter.Add(6,88,4,2,4,99,12345);
            //var erg2 = Parameter.Add(zahlen);
            //Console.WriteLine(erg); 
            ////int i = 5;
            ////Parameter.MachEtwas(i); // Übergabe per Wert (Kopie)
            ////Console.WriteLine(i);

            ////Person p = new Person("Tom","Ate",12345);
            ////Parameter.MachEtwas(p); // Übergabe per Wert (Kopie)
            ////Console.WriteLine(p.Vorname);

            ////int i = 5;
            ////Parameter.MachEtwasReferenz(ref i); // Übergabe per Referenz
            ////Console.WriteLine(i);

            ////Person p = new Person("Tom", "Ate", 12345);
            ////Parameter.MachEtwasReferenz(ref p); // Übergabe per Referenz
            ////Console.WriteLine(p.Vorname);

            ////Parameter.MachEtwasReadonlyReferenz(i);

            //int erg = 0;
            //bool erfolg = Parameter.KannIchKonvertierenFragezeichen("123", out erg);

            //Parameter.MachEtwasOptional("meinem Text");
            //Parameter.MachEtwasOptional(); 
            #endregion

            //Händler max = new Händler();
            //max.Anzahl = 5000;
            //max.Produkt = new Obst();
            //max.Produkt.Name = "Apfel";
            //max.Produkt.Herkunft = "Steiermark";
            //max.Produkt.Preis = 0.80m;
            //max.Produkt.Kcal = 80;

            Händler martha = new Händler();
            martha.Anzahl = 100;
            Obst o1 = new Obst();
            o1.Name = "Banane";
            o1.Herkunft = "Brasilien";
            o1.Preis = 1.20m;
            o1.Kcal = 120;
            martha.Produkt = o1;

            Händler klara = new Händler();
            klara.Anzahl = 200;
            // Objektinitialisierer
            klara.Produkt = new Obst()
            {
                Name = "Orangen",
                Herkunft = "Spanien",
                Preis = 0.50m,
                Kcal = 90
            };

            Händler hannes = new Händler
            {
                Anzahl = 500,
                Produkt = new Gemüse
                {
                    Name = "Irische Kartoffel",
                    Preis = 12.99m
                }
            };

            if(hannes.Produkt is Gemüse g)
            {
                g.Bitter = true;
            }

            Gemüse g1 = (Gemüse)hannes.Produkt;
            Console.WriteLine(g1);

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
