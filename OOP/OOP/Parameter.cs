using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Parameter
    {
        //public int Add(int z1, int z2)
        //{
        //    return z1 + z2;
        //}
        //public int Add(int z1, int z2, int z3)
        //{
        //    return z1 + z2 + z3;
        //}

        // params
        public static int Add(params int[] zahlen)
        {
            return zahlen.Sum();
        }

        // Übergabe per Wert
        public static void MachEtwas(int zahl)
        {
            zahl *= 2;
        }
        public static void MachEtwas(Person person)
        {
            person.Vorname = "Anna";
        }

        // Übergabe per Referenz
        public static void MachEtwasReferenz(ref int zahl)
        {
            zahl *= 2;
        }
        public static void MachEtwasReferenz(ref Person person)
        {
            person.Vorname = "Anna";
        }
        // readonly reference
        public static void MachEtwasReadonlyReferenz(in int zahl)
        {
            zahl *= 2;
        }

        // erzwungene Ausgabe über out: quasi wie ref, nur mit einem Fehler wenn es keine Wertzuweisung gib
        public static bool KannIchKonvertierenFragezeichen(string text,out int konvertierteZahl)
        {
            // if ... kann konvertieren
            konvertierteZahl = 42;
            return true;
        }
        public static void MachEtwasOptional(string text = "nix") // optionaler Parameter
        {
            Console.WriteLine("Ich mach etwas mit:" + text);
        }

    }
}
