namespace OOP
{
    class Kreis : Grafik
    {
        public Kreis(string farbe,int radius) : base(farbe)
        {
            Radius = radius;
        }

        public int Radius { get; set; }
    }
}
