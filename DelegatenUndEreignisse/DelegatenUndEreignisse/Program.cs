using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatenUndEreignisse
{
    class Program
    {
        // Delegate-Typ: Signatur vorgeben
        public delegate void MeinDelegat(); // void und keine Parameter
        public delegate int Rechenart(int z1, int z2);

        static void Main(string[] args)
        {
            // delegate -> Zeiger auf Methoden
            //MeinDelegat del = new MeinDelegat(A);
            //del += B;
            //del += C;
            //del();

            #region Variante ohne Delegat
            //Console.WriteLine("Bitte geben Sie die erste Zahl ein:");
            //int zahl1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
            //int zahl2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Bitte geben Sie den Operator ein:");
            //string op = Console.ReadLine();

            //int erg = 0;
            //if (op == "+")
            //    erg = zahl1 + zahl2;
            //else if (op == "-")
            //    erg = zahl1 - zahl2;
            //// ...

            //Console.WriteLine($"Das Ergebnis ist : {erg}"); 
            #endregion

            #region Variante mit Delegat
            //Console.WriteLine("Bitte geben Sie die erste Zahl ein:");
            //int zahl1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
            //int zahl2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Bitte geben Sie den Operator ein:");
            //string op = Console.ReadLine();

            //Rechenart rechenart = null;

            //if (op == "+")
            //    rechenart = Add;
            //else if (op == "-")
            //    rechenart = Sub;
            //// ..

            //Console.WriteLine($"Das Ergebnis ist : {rechenart(zahl1,zahl2)}"); 
            #endregion

            #region Action und Func
            // Methoden ohne Rückgabe
            // Action

            //Action methodeOhneParameter = A;
            //methodeOhneParameter += B;
            //Action<int> methodeMitEinemParameter = C;
            //methodeMitEinemParameter += A;

            //// Methoden mit Rückgabe
            //// Func

            //Func<int, int, int> rechnung = Sub; // int rein, int rein, int raus
            //rechnung += Add;
            //int erg = rechnung(12, 5); 
            #endregion

            // EventHandler eh = new EventHandler()

            Button b = new Button();
            b.Text = "Klick mich";
            b.Farbe = "Grün";

            b.ButtonClickEvent += MeinButtonKlick;
            b.ButtonClickEvent += Logger;

            b.Klick();

            // b.ButtonClickEvent = null;               // absolut verboten

            b.Klick();
            b.Klick();

            b.ButtonClickEvent -= Logger;
            b.Klick();
            b.Klick();

            // b.ButtonClickEvent(null, null);      // selbst auslösen -> verboten


            Console.WriteLine("---ENDE---");
            Console.ReadKey();
            EventHandler<MeineEigenenArgumente> demo = DieMethode;

        }

        private static void DieMethode(object sender, MeineEigenenArgumente e)
        {
            throw new NotImplementedException();
        }

        private static void Logger(object sender, EventArgs e)
        {
            Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}]: Button wurde geklickt");
        }

        private static void MeinButtonKlick(object sender, EventArgs e)
        {
            Console.WriteLine("*click*");
            Console.Beep();
        }

        private static int Add(int z1, int z2)
        {
            return z1 + z2;
        }
        private static int Sub(int z1, int z2)
        {
            return z1 - z2;
        }

        private static void A()
        {
            Console.WriteLine("A");
        }
        private static void B()
        {
            Console.WriteLine("B");
        }
        private static void C(int zahl)
        {
            Console.WriteLine($"C {zahl}");
        }

    }
}
