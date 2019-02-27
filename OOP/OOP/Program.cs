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

            Person p1 = new Person();
            p1.AlterSetzen(12);
            p1.AlterSetzen(55);
            p1.AlterSetzen(255);

            Console.WriteLine(p1.AlterAuslesen());

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
