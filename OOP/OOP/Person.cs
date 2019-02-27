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
    // Konstruktor:     Wird beim Erstellen eines Objektes aufgerufen
    // Destruktor:      Wird beim Löschen des Objektes aufgerufen

    // Gültigkeitsspezifizierer:
    // public:              -> Zugriff von überall aus möglich ist
    // private:             -> Zugriff ist nur von innerhalb der eigenen Klasse aus möglich
    //   private ist der Standardfall für Felder (Variablen)
    // protected:           -> Zugriff nur von der eigenen Klasse + alle Klassen die davon erben möglich
    // internal:            -> Zugriff innerhalb der Assembly wie public, ausserhalb wie private
    // protected internal:  -> kombi aus internal + alle die davon erben (in anderen Assemblies)
    // private protected:   -> Protected gilt nur in meiner eigenen Assembly

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


        // Übung:
        // Klasse "Fahrzeug"
        /* int Geschwindigkeit (lesen und schreiben) -> Schreiben: 0 - 250
         * int Kilometerstand (lesen erlaubt, schreiben private)
         * string Fahrer (autoprop)
         * 
         * Methode:
         * Fahren(int Stunden) -> Aktuelle Geschwindigkeit wird X stunden gefahren -> Kilometerstand erhöht sich
         * 
         * Main():
         * 1 Fahrzeug erstellen, kilometerstand ausgeben,
         * 100 kmh als geschwindigkeit setzen, 5 stunden fahren
         * kilometerstand ausgeben
         */


        // Readonly-Property:
        private string vn;
        private string nn;

        public string GanzerName
        {
            get
            {
                return $"{vn} {nn}";
            }
        }

        // Konstruktor:
        // Gültigkeit NameDerKlasse()
        // ctor + TAB + TAB
        //public Person(string Vorname, string Nachname)
        //{
        //    this.Vorname = Vorname;
        //    this.Nachname = Nachname;
        //}

        // QuickActions and Refactoring -> Generate Constructor ->
        //public Person(decimal kontostand, string vorname, string nachname)
        //{
        //    Kontostand = kontostand;
        //    Vorname = vorname;
        //    Nachname = nachname;
        //}

        // Mini-Übung: Erstellts einen Konstruktor für euer Fahrzeug
        // Das Fahrzeug braucht immer einen Fahrer und einen kilometerstand

        // Destruktor:
        // Wird immer aufgerufen, wenn der GC das Objekt aus dem Heap entfernt
        // Idealer Ort um Drittressourcen (DB-Connection) wieder freizugeben
        ~Person()
        {
            Console.WriteLine("Ich werde gelöscht :( ");
        }

        //public Person()
        //{
        //    Vorname = "Tom";
        //    Nachname = "Ate";
        //    Alter = 10;
        //    Kontostand = 100;
        //}

        public Person(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
        }
        public Person(string vorname, string nachname,decimal kontostand)
        {
            Vorname = vorname;
            Nachname = nachname;
            Kontostand = kontostand;
        }
    }
}
