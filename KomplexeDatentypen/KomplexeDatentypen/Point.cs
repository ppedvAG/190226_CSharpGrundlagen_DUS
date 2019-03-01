namespace KomplexeDatentypen
{
    // -> Landet auf dem Stack
    // Features/Limitierungen:
    // Es muss immer ein parameterloser Konstruktor da sein
    // Bei einem Konstruktor müssen -alle- Werte gesetzt werden
    // Ein Strukt kann nicht von einem anderen Strukt erben (dementsprechend gibts kein "protected")
    // -- Interfaces kann man aber implementieren
    // Structs werden mit dem Verlassen einer Methode/Codeblock/o.Ä. sofort gelöscht und müssen nicht wie im Vgl. zu Objekten auf den GC warten bis sie entfernt werden
    // -- Es gibt keinen Destruktor
    // Es gelten Wertevergleich und Wertekopie
    struct Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
