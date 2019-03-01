using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace KomplexeDatentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            //int[] zahlen = new int[5];
            //zahlen[0] = 5;              // [] -> Indexer
            //zahlen[1] = 15;
            //zahlen[2] = 115;
            //zahlen[3] = 1115;
            //zahlen[4] = 11115;

            //string text = "Hallo Welt";
            //char c = text[2];
            //Console.WriteLine(c); 
            #endregion

            #region ArrayList
            //var liste = new ArrayList();
            //liste.Add(12);
            //liste.Add("Hallo Welt");
            //liste.Add(12.555555);
            //liste.Add(true);

            //// Nachteil: Keine Typensicherheit
            //liste.RemoveAt(0);
            //string meinWert = (string)liste[1];
            //Console.WriteLine(meinWert); 
            #endregion

            #region Hashtable
            //Hashtable table = new Hashtable();
            //// Key: Eindeutiger Wert
            //// Value: Wert, der hinter dem "Key" steht

            //table.Add("Demo", 12);
            //table.Add(true, "ein boolischer Wert");
            //table.Add(3.14, 12);
            //// table.Add("Demo", 1231231231212);

            //Console.WriteLine( table[3.14] ); 
            #endregion

            #region List<T>
            //List<int> zahlenListe = new List<int>();
            //zahlenListe.Add(123);
            //zahlenListe.Add(99);
            //zahlenListe.Add(3);
            //zahlenListe.Add(15);

            //List<string> meineWörter = new List<string>();
            //meineWörter.Add("Demo") 
            #endregion

            #region Dictionary<TKey,TValue>
            //// [] -> Indexer
            //// <> -> Datentypen
            //Dictionary<string, string> länder = new Dictionary<string, string>();
            //länder.Add("Österreich", "Wien");
            //länder.Add("Ungarn", "Budapest");
            //länder.Add("Tschechien", "Prag");
            //länder.Add("Slowenien", "Laibach");


            //Console.WriteLine(länder["Ungarn"]); // Wert dahinter
            //if(länder.ContainsKey("Kosovo"))     // Wert dahinter
            //    Console.WriteLine(länder["Kosovo"]); 
            //else
            //    Console.WriteLine("Leider nicht in den UN"); 
            #endregion

            #region Stack<T>
            //// LIFO
            //Stack<int> meinStack = new Stack<int>();

            //meinStack.Push(12); // Elemente auf den Stack drauflegen
            //meinStack.Push(9); // Elemente auf den Stack drauflegen
            //meinStack.Push(3); // Elemente auf den Stack drauflegen

            //Console.WriteLine(meinStack.Pop());
            //Console.WriteLine(meinStack.Pop());
            //Console.WriteLine(meinStack.Pop()); 
            #endregion

            #region Queue<T>
            //// FIFO
            //Queue<string> meineReihe = new Queue<string>();

            //meineReihe.Enqueue("Hallo");
            //meineReihe.Enqueue("Welt");
            //meineReihe.Enqueue("!");

            //Console.WriteLine(meineReihe.Dequeue());
            //Console.WriteLine(meineReihe.Dequeue());
            //Console.WriteLine(meineReihe.Dequeue()); 
            #endregion

            // IComparer
            // SortedList und SortedDictionary
            // Span<T> -> "Liste" auf dem Stack (NuGet: System.Memory)

            #region HashSet<T>
            // Liste, in der kein Element doppelt vorkommen kann
            //HashSet<int> keineDoppelten = new HashSet<int>();
            //keineDoppelten.Add(12);
            //keineDoppelten.Add(3);
            //keineDoppelten.Add(9);
            //keineDoppelten.Add(4);
            //keineDoppelten.Add(12);
            //keineDoppelten.Add(9);

            //foreach (var item in keineDoppelten)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Struct
            //Point p = new Point(); // im vgl zur Klasse keine "NullReferenceException"
            //Point p2 = p; // Wertekopie

            //Console.WriteLine(p.X);
            //Console.WriteLine(p.Y); 
            #endregion

            #region Enum
            //Wochentage heute = Wochentage.Freitag;

            //if(heute == Wochentage.Montag)
            //    Console.WriteLine("Arbeiten gehen !!!");

            //// Feature in VS für den Switch: Alle Optionen werden automatisch generiert

            //Wochentage wecker = Wochentage.Montag | Wochentage.Dienstag | Wochentage.Mittwoch;


            //Console.WriteLine(wecker);
            //// if (wecker.HasFlag(Wochentage.Montag))
            //    // Console.Beep(22000, 10000); // *ringring*

            //Wochentage demo = (Wochentage)0b0101; // Mo + Mi
            //Console.WriteLine(demo); 
            #endregion

            #region Erweiterungsmethoden
            //string text = "Hallo Welt";
            //int zahl = 12;
            //int erg = zahl.Verdoppeln();
            //Erweiterungsmethoden.Verdoppeln(zahl); 
            #endregion

            // Lambda-Ausdrücke "=>"

            List<Person> personen = new List<Person>
            {
                new Person{Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=100,Geschlecht=Geschlecht.Männlich },
                new Person{Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=2000,Geschlecht=Geschlecht.Weiblich },
                new Person{Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=-300,Geschlecht=Geschlecht.KeineAngabe },
                new Person{Vorname="Franz",Nachname="Ose",Alter=40,Kontostand=400000,Geschlecht=Geschlecht.Männlich },
                new Person{Vorname="Martha",Nachname="Pfahl",Alter=50,Kontostand=555100,Geschlecht=Geschlecht.Weiblich },
                new Person{Vorname="Klara",Nachname="Fall",Alter=60,Kontostand=-6666,Geschlecht=Geschlecht.ApacheKampfhubschrauber },
                new Person{Vorname="Rainer",Nachname="Zufall",Alter=70,Kontostand=1234,Geschlecht=Geschlecht.Männlich },
                new Person{Vorname="Axel",Nachname="Schweiß",Alter=80,Kontostand=-100,Geschlecht=Geschlecht.Weiblich },
                new Person{Vorname="Anna",Nachname="Bolika",Alter=90,Kontostand=19897500,Geschlecht=Geschlecht.Weiblich },
                new Person{Vorname="Albert",Nachname="Tross",Alter=100,Kontostand=-10000000,Geschlecht=Geschlecht.ApacheKampfhubschrauber },
            };

            // LINQ -> Language Integrated Query

            #region Variante ohne LINQ
            //// Erstelle eine Liste mit allen Nachnamen von allen Personen
            //List<string> alleNachnamen = new List<string>();
            //foreach (var item in personen)
            //{
            //    alleNachnamen.Add(item.Nachname);
            //}

            //// Erstelle eine Liste mit allen Nachnamen von Personen mit einem negativen Kontostand
            //List<string> alleNachnamenMitSchulden = new List<string>();
            //foreach (var item in personen)
            //{
            //    if(item.Kontostand < 0)
            //    {
            //        alleNachnamenMitSchulden.Add(item.Nachname);
            //    }
            //}

            //// Erstelle eine Liste mit allen Nachnamen von Personen mit einem negativen Kontostand
            //// -> Sortiert nach Alter absteigend
            //List<string> alleNachnamenMitSchulden_SortiertnachAlter = new List<string>();
            //foreach (var item in personen)
            //{
            //    if (item.Kontostand < 0)
            //    {
            //        alleNachnamenMitSchulden_SortiertnachAlter.Add(item.Nachname);
            //    }
            //}

            //// Alle Personen älter als 50 mit Kontostand > 10_000 sortiert nach alter
            //// Finde die Person mit dem höchsten Kontostand
            //// Durchschnittliches alter aller personen mit schulden 
            #endregion
            #region LINQ

            //// Select -> Elemente/Wert herausnehmen

            //// Aufgabe: Erstelle eine Liste mit allen Nachnamen von allen Personen
            //// Func<Person, string> nachnamenFilter = FilterNachNachnamen;
            //// var alleNachnamen = personen.Select(nachnamenFilter).ToList();

            //var alleNachnamen = personen.Select(person => person.Nachname).ToList();
            //var jederAlter = personen.Select(x => x.Alter).ToArray();

            //// Where -> Filtern nach Bedingung
            //// Aufgabe: Erstelle eine Liste mit allen Nachnamen von Personen mit einem negativen Kontostand

            //var alleMitNegativemKontostand = personen.Where(x => x.Kontostand < 0).ToList();

            //// Aufgabe: Erstelle ein Array mit allen Nachnamen von Personen mit einem negativen Kontostand
            ////          -> Array mit Nachnamen von Personen mit negativem Kontostand

            //var nachnamenNegativ = personen.Where(x => x.Kontostand < 0)
            //                               .Select(x => x.Nachname)
            //                               .ToArray();

            //// OrderBy , OrderByDescending

            //var personenMitNegativemKontostandSortiertNachAlter = personen.Where(x => x.Kontostand < 0)
            //                                                              .OrderByDescending(x => x.Alter)
            //                                                              .ToList();

            //// Wenn man einzelne Elemente haben will:
            //// First(), Last()

            //var personMitHöchstemKontostand = personen.OrderByDescending(x => x.Kontostand)
            //                                          .First();
            //// Eine bestimmte Anzahl herausnehmen
            //// Take()
            //var FünfPersonenMitHöchstemKontostand = personen.OrderByDescending(x => x.Kontostand)
            //                                                .Take(5)
            //                                                .ToList();

            //// Operationen:
            //// Sum(), Average(), Min(), Max()
            //var durchschnittlichesAlterVonPersonenMitNegativemKontostand = personen.Where(x => x.Kontostand < 0)
            //                                                                       .OrderByDescending(x => x.Kontostand)
            //                                                                       .Take(personen.Count(x => x.Kontostand <1) - 1)
            //                                                                       .Average(x => x.Alter);

            #endregion

            #region LINQ - Übung

            //// Alle männlichen Personen über 40 als Liste
            //var ü1 = personen.Where(person => person.Alter > 40 && person.Geschlecht == Geschlecht.Männlich)
            //                 .ToList();

            //// Durchschnittliches Alter aller weiblichen Personen
            //var ü2 = personen.Where(x => x.Geschlecht == Geschlecht.Weiblich)
            //                 .Average(x => x.Alter);

            //// Nachnamen aller "ApacheKampfhubschrauber" als Array
            //var ü3 = personen.Where(x => x.Geschlecht == Geschlecht.ApacheKampfhubschrauber)
            //                 .Select(x => x.Nachname)
            //                 .ToArray();

            //// Alle Personen unter 50 mit einem Kontostand > 100, sortiert nach Alter absteigend
            //var ü4 = personen.Where(x => x.Alter < 50 && x.Kontostand > 100)
            //                 .OrderByDescending(x => x.Alter)
            //                 .ToArray();

            //// Die eine Person älter als 40 mit dem höchsten Kontostand
            ////var ü5 = personen.Where(person => person.Alter > 40)
            ////                 .OrderByDescending(person => person.Kontostand)
            ////                 .First();

            //var ü5v2 = personen.OrderByDescending(person => person.Kontostand)
            //                   .First(x => x.Alter > 40);

            //// Die ersten 5 Personen mit negativem Kontostand 
            //var ü6 = personen.Where(x => x.Kontostand < 0)
            //                 .Take(5); 
            #endregion



            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }

        //private static bool HatNegativenKontostand(Person x) => x.Kontostand < 0;
        //{
        //    //if (x.Kontostand < 0)
        //    //    return true;
        //    //else
        //    //    return false;

        //    return x.Kontostand < 0;
        //}

        private static string FilterNachNachnamen(Person arg)
        {
            return arg.Nachname;
        }
        private static string FilterNachNachnamen2 (Person arg) => arg.Nachname;

        public static int Addieren(int z1, int z2)
        {
            return z1 + z2;
        }
        public static int Subtrahieren(int z1, int z2) => z1 - z2;
        public static int Multiplizieren(int z1, int z2) => z1 * z2;
        public static int Dividieren(int z1, int z2) => z1 / z2;

    }
}
