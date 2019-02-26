﻿using System;
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

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
