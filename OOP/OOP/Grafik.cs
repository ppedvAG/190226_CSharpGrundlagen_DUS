using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Grafik
    {
        public Grafik(string farbe)
        {
            Farbe = farbe;
        }
        public string Farbe { get; set; }

        public virtual void Zeichnen() // virtual macht die Methode überschreibbar mit override
        {
            Console.WriteLine($"Eine Grafik mit der Farbe {Farbe} wird gezeichnet");
        }
    }
}
