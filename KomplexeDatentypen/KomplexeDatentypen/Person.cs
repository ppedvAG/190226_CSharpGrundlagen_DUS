using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexeDatentypen
{
    [Flags] // <--- Attribut, zusätzliche Metadaten
    enum Wochentage
    {
        Montag = 1,
        Dienstag = 2,
        Mittwoch = 4,
        Donnerstag = 8,
        Freitag = 16,
        Samstag = 32,
        Sonntag = 64
    }
    enum Geschlecht
    {
        Männlich,Weiblich,KeineAngabe,ApacheKampfhubschrauber
    }

    // -> Landet auf dem Heap
    class Person
    {
        //public Person(string vorname,string nachname)
        //{
        //    Vorname = vorname;
        //    Nachname = nachname;
        //}

        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public byte Alter { get; set; }
        public decimal Kontostand { get; set; }
        public Geschlecht Geschlecht { get; set; } // true = männlich, false = weiblich
    }
}
