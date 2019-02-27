using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // Interface:
    // 1) alles ist Public
    interface IProdukt
    {
        string Name { get; set; }
        decimal Preis { get; set; }

        // void Demo(); // wie bei abstract:
    }
}
