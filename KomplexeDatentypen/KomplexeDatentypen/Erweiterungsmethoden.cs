using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexeDatentypen
{
    // Wichtig:
    // 1) statische Klasse
    static class Erweiterungsmethoden
    {
        // 2) "this" - beim Parameter
        public static int Verdoppeln(this int zahl)
        {
            return zahl * 2;
        }

        //public static string Umdrehen(this string text)
        //{

        //}
    }
}
