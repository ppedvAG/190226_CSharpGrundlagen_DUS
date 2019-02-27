using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Taschenrechner
    {
        // Überladen:
        // Wichtig: Unterschiedliche Anzahl der Parameter und/oder unterschiedliche Datentypen
        public int Add(int z1, int z2)
        {
            return z1 + z2;
        }
        public int Add(int z1, int z2, int z3)
        {
            return z1 + z2 + z3;
        }
    }
}
