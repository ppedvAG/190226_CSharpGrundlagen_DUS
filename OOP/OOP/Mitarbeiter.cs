using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // Vererbung
    internal class Mitarbeiter : Person
    {
        public Mitarbeiter() : base("Max", "Mustermann",12)
        {
        }

        //public Mitarbeiter()
        //{
        //    Vorgesetzer = "Anna Nass";
        //    Abteilung = "HR";
        //}

        // die eigentlich "korrekte" variante
        //public Mitarbeiter() : base("Max","Mustermann")
        //{
        //    Vorgesetzer = "Anna Nass";
        //    Abteilung = "HR";
        //}

        public string Vorgesetzer { get; set; }
        public string Abteilung { get; set; }
    }
}
