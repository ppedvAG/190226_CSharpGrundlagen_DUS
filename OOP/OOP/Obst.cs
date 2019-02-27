using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Obst : IProdukt
    {
        public string Name { get; set; }
        public string Herkunft { get; set; }
        public decimal Preis { get; set; }
        public int Kcal { get; set; }
    }
}
