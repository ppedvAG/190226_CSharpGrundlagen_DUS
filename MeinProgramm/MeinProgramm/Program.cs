using MeineLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MeinProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            Console.WriteLine("Ich bin im DEBUG-Modus");
#endif

            var erg = Taschenrechner.Add(12, 3);
            Console.WriteLine(erg);

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
