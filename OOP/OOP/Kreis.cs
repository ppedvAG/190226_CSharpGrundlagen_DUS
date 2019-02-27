using System;

namespace OOP
{
    class Kreis : Grafik
    {
        public Kreis(string farbe,int radius) : base(farbe)
        {
            Radius = radius;
        }

        public int Radius { get; set; }

        // Überschreiben einer Methode
        // override gilt gleichzeitig wie virtual
        // sealed override -> verhindert weiteres überschreiben
        public override void Zeichnen() 
        {
            // base.Zeichnen(); // <---- Ruft das originale Zeichnen aus der Basisklasse auf
            Console.WriteLine($"Ein Kreis mit der Farbe {Farbe} und dem Radius {Radius} wird gezeichnet");
        }
    }

    //class Ellipse : Kreis
    //{
    //    public override void Zeichnen()
    //    {
    //        base.Zeichnen();
    //    }
    //}
}
