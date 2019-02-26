using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWelt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pascal-Case      DasIstEinLangerSatz => Klassen/Methoden/Properties
            // Camel-Case       meineErsteZahl => lokale Variablen

            Console.WriteLine("Hallo Welt");

            #region Tastenkürzel
            // F1 -> Dokumentation/Hilfe
            // F5 -> Starten (mit Debugger)
            // F9 -> Haltepunkt/Breakpoint setzen
            // F10 / F11 -> Einzelschritt
            // F12 -> Zur Definition springen
            // STRG + D -> Duplizieren
            // STRG + C/V/X -> Kopieren/Einfügen/Ausschneiden -> Ohne Markierung ist die gesamte Zeile betroffen
            // ALT + PfeilRauf/Runter -> Codezeile verschieben
            // ALT + Markieren -> Innerhalb der Markierung in mehreren Codezeilen schreiben

            // STRG + K + C -> Auskommentieren
            // STRG + K + U -> Kommentar entfernen
            // STRG + K + D -> Formatierung richten
            #endregion

            #region Variablen
            //int zahl1;          // Deklaration
            //int zahl2 = 12;     // Deklaration + Initialisierung

            //int z1, z2, z3;     // 3 Int werden erstellt
            //int z4 = 5, z5 = 10, z6 = 100; // Deklaration + Initialisierung

            //var meineZahl = 5.33333;  // Zuweisung bestimmt den Datentypen 
            #endregion

            // Snippet für Console.WriteLine
            // cw + TAB + TAB

            // Suffix für numerische Werte:
            //      F: float
            //      D: double
            //      U: uint
            //      L: long
            //      UL: ulong
            //      M:  decimal


            #region Konvertieren
            //// Implizit
            //int zahl1 = 5;
            //long zahl2 = 10;

            //zahl2 = zahl1; // Implizit Konvertieren -> "der kleinere Wert passt in den größeren Wertebereich hinein"
            //zahl2 = 50;

            //// zahl1 = zahl2; // "der größere Wert passt nicht in den kleineren Wertebereich hinein"

            //// Explizit
            ////zahl1 = Convert.ToInt32("abcde123",System.Globalization.CultureInfo.CurrentCulture);
            //zahl1 = Int32.Parse("123");

            //// double zahl3 = Convert.ToDouble("12.5");
            //// Console.WriteLine(zahl3);

            //string eingabe = Console.ReadLine();
            //Console.WriteLine("Deine Eingabe war: " + eingabe);

            //// Mini-Übung:
            //// "Addierer" : 2 Zahlen einlesen und die Summe ausgeben

            //// Boxing
            //// In C# ist alles ein object

            //int i = 12;
            //object o = i; // Boxing

            //// (int) => Casting
            //int meineZahl99 = (int)o; // Unboxing - operation

            //Console.WriteLine(o.GetType()); 
            #endregion

            #region Verzweigung
            //int zahl1 = 5;
            //int zahl2 = 10;

            //if(zahl1 > zahl2)
            //{
            //    Console.WriteLine("größer");
            //}
            //else if(zahl1 == zahl2)
            //{
            //    Console.WriteLine("gleich");
            //}
            //else
            //{
            //    Console.WriteLine("kleiner");
            //}

            //// if( (zahl1 > 0) && (zahl2 < 100)) 
            #endregion

            #region Switch
            //int zahl1 = 5;

            //switch (zahl1)
            //{
            //    case 1:
            //        Console.WriteLine("Eins");
            //        break;
            //    case 2:
            //        Console.WriteLine("Zwei");
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("Drei, Vier oder Fünf");
            //        break;
            //    case 10:
            //        Console.WriteLine("Zehn");
            //        goto case 2;
            //    default:
            //        Console.WriteLine("irgendwas anderes ...");
            //        break;
            //} 
            #endregion

            #region Operatoren
            //// Arithmetische Operatoren
            //// +,-,*,/, % (mod)
            //// +=, -= ...
            //// ++, --

            //// Bit-Operatoren
            //// &, | , ^, ~ (invert), <<, >>

            //int zahl1 = 5;
            //int erg;
            //erg = zahl1++; // Postincrement

            //Console.WriteLine(zahl1);
            //Console.WriteLine(erg);
            //zahl1 = 5;

            //erg = ++zahl1; // Preincrement
            //Console.WriteLine(zahl1);
            //Console.WriteLine(erg);

            //// Scherzfrage
            ////int meineZahl = 5;

            ////int ergebnis = meineZahl++ + ++meineZahl;
            ////Console.WriteLine(ergebnis); 
            #endregion

            #region Schleifen
            //// Zählergesteuert
            //// initialisierung;bedingung;aktualisierung
            //// for(int i = 0; i<10 ;i++)
            //// {
            ////     Console.WriteLine(i);
            //// }
            //// for + TAB + TAB
            //// forr + TAB + TAB -> Rückwärts-Variante

            //// Bedingungsgesteuert

            ////int zahl1 = 2000;
            ////// Kopfgesteuert
            ////while (zahl1 < 100)
            ////{
            ////    Console.WriteLine(++zahl1);
            ////}

            //////Fußgesteuert
            ////do
            ////{
            ////    Console.WriteLine(zahl1--);
            ////} while (zahl1 > 0);

            //// Schleifensteuerung
            //// break; --> Schleife beenden
            //// continue; --> gehe zum nächsten durchgang 
            #endregion

            #region Arrays
            //int[] zahlen = new int[10]; // 0,1,2,3...9 => 10 Anzahl
            //zahlen[0] = 12;
            //zahlen[1] = 5;
            //Console.WriteLine(zahlen[0]);

            //// Array-Initialisierer

            //int[] zahlen2 = new int[] { 9, 12, 4, 7 };
            //int[] zahlen3 = { 9, 12, 4, 7 };

            //// Mehrdimensional
            //int[,] schachbrett = new int[8, 8];
            //schachbrett[0, 0] = 12;
            //schachbrett[0, 1] = 9;

            //// Jagged-Array
            //int[][] jaggedArray = new int[5][];
            //jaggedArray[0][10] 

            //object[] alles = new object[2];
            //alles[0] = 12;
            //alles[1] = "Hallo Welt";

            //int zahl1 = (int)alles[0];
            #endregion

            #region Foreach
            //int[] meineZahlen = { 12, 3, 7, 3, 21, 4, 6, 7, 99 };

            //for (int i = 0; i < meineZahlen.Length; i++)
            //{
            //    Console.WriteLine(meineZahlen[i]);
            //}

            //foreach (int item in meineZahlen)
            //{
            //    Console.WriteLine(item * 2);
            //} 
            #endregion

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
