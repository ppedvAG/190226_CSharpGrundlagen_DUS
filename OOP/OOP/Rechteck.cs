using System;

namespace OOP
{
    class Rechteck : Grafik
    {
        public Rechteck(string farbe,int höhe, int breite) : base(farbe)
        {
            Höhe = höhe;
            Breite = breite;
        }

        public int Höhe { get; set; }
        public int Breite { get; set; }

        // Verstecken
        // new -> Verstecken, funktioniert aber auch ohne dem Schlüsselwort
        // Verstecken ist immer möglich, auch wenn die Methode nicht "virtual" ist
        public void Zeichnen()
        {
            Console.WriteLine($"Ein Rechteck mit der Farbe {Farbe}, der Höhe {Höhe} und der Breite {Breite} wird gezeichnet");
        }
    }
}
