using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiederholungOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            IMotor m1 = new MichiMotor();
            IBremssystem b1 = new MichiBremse();

            Fahrzeug f1 = new Fahrzeug(m1,b1);

            f1.Beschleunigen();
            f1.Beschleunigen();

            f1.Fahren(3);

            Console.WriteLine($"Aktuelle Geschwindigkeit: {f1.AktuelleGeschwindigkeit}");
            Console.WriteLine($"Aktueller Kilometerstand: {f1.Kilometerstand}");
            f1.Bremsen();

            f1.Fahren(5);
            Console.WriteLine($"Aktuelle Geschwindigkeit: {f1.AktuelleGeschwindigkeit}");
            Console.WriteLine($"Aktueller Kilometerstand: {f1.Kilometerstand}");

            Console.WriteLine("---ENDE---");
            Console.ReadKey();

            // Ziel: 
            // Jeder erstellt einen Motor und ein Bremssystem
            // Diese Systeme untereinander Teilen
        }
    }
}
