using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // Begriffe:
    // Klasse:          Der "Bauplan" - Definition, wie das Objekt aussehen soll
    // Objekt/Instanz:  Die "Realisierung" der Klasse
    // Feld:            Variable in einer Klasse
    // Methode:         Funktionalität in der Klasse (Subprozedur oder Funktion)
    // Property:        Steuert den Lese+Schreibzugriff auf ein Feld

    // Gültigkeitsspezifizierer:
    // public:              -> Zugriff von überall aus möglich ist
    // private:             -> Zugriff ist nur von innerhalb der eigenen Klasse aus möglich
    //   private ist der Standardfall für Felder (Variablen)

    class Person
    {
        #region Felder
        //public string Vorname;
        //public string Nachname;
        //public byte Alter;
        //public decimal Kontostand;
        //public bool Geschlecht; 
        #endregion
        #region Variante "Java"

        //private byte alter;

        //// Methode: 
        //// sichtbarkeit rückgabe name (parameter)
        //// { .... }
        //// void == keine rückgabe (subprozedur)
        //public void AlterSetzen(byte neuesAlter)
        //{
        //    if (neuesAlter > 150)
        //        Console.WriteLine("Ungültiges Alter");
        //    else
        //        alter = neuesAlter;
        //}

        //// byte -> rückgabetyp
        //public byte AlterAuslesen()
        //{
        //    return alter; // return -> wert zurückgeben als "Ergebnis" der Funktion
        //} 
        #endregion

        private byte alter; // Schreibweise: alles was privat ist, wird kleingeschrieben
        public byte Alter
        {
            get // Lesezugriff
            {
                return alter;
            }
            private set // Schreibzugriff, value ist der "neue Wert"
            {
                if (value > 150)
                    Console.WriteLine("Ungültiges Alter");
                else
                    alter = value;
            }
        }
        public void Geburtstag()
        {
            Alter++;
        }

        // Property automatisch erstellen:
        // propfull + TAB + TAB

        private decimal kontostand;
        public decimal Kontostand
        {
            get { return kontostand; }
            set { kontostand = value; }
        }

        // Autoproperty:
        // prop + TAB + TAB
        public string Vorname { get; set; }
        public string Nachname { get; set; }

    }
}
