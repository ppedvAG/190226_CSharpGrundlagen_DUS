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

        private byte alter;

        // Methode: 
        // sichtbarkeit rückgabe name (parameter)
        // { .... }
        // void == keine rückgabe (subprozedur)
        public void AlterSetzen(byte neuesAlter)
        {
            if (neuesAlter > 150)
                Console.WriteLine("Ungültiges Alter");
            else
                alter = neuesAlter;
        }

        // byte -> rückgabetyp
        public byte AlterAuslesen()
        {
            return alter; // return -> wert zurückgeben als "Ergebnis" der Funktion
        }
    }
}
