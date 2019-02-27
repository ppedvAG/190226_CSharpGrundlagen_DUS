using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    static class SpezialTaschenrechner // erzwingt, dass alles in der klasse static ist
    {
        public static int Add(int z1, int z2) // Ohne Objekt aufrufbar
        {
            return z1 + z2;
        }
        public static int Sub(int z1, int z2)
        {
            return z1 - z2;
        }
    }
}
