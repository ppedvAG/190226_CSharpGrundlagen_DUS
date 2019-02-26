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

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
