using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Gemüse : IProdukt
    {
        public string Name { get; set ; }
        public decimal Preis { get; set; }
        public bool Bitter { get; set; }
    }
}
