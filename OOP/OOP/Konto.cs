using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // Abstract -> "Vorlagenklasse"
    abstract class Konto
    {
        public decimal Kontostand { get; set; } // kann auch abstract sein

        public virtual void Einzahlen(decimal betrag)
        {
            Kontostand += betrag;
        }
        public abstract void Abheben(decimal betrag); // abstract - Methode: Jede Subklasse ihre eigene Version selbst bauen muss
    }


    class Jugendkonto : Konto
    {
        public override void Abheben(decimal betrag)
        {
            // Abheben: Kontostand darf nicht unter 0 
            throw new NotImplementedException();
        }
    }

    class Girokonto : Konto
    {
        public override void Abheben(decimal betrag)
        {
            // Abheben: Kontostand darf max -2000 (Überziehungsrahmen)
            throw new NotImplementedException();
        }
    }
}
