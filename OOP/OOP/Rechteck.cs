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
    }
}
