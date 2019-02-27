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

    // Gültigkeitsspezifizierer:
    // public:              -> Zugriff von überall aus möglich ist
    // private:             -> Zugriff ist nur von innerhalb der eigenen Klasse aus möglich
    //   private ist der Standardfall für Felder (Variablen)

    class Person
    {
        public string Vorname;
        public string Nachname;
        public byte Alter;
        public decimal Kontostand;
        public bool Geschlecht;
    }
}
