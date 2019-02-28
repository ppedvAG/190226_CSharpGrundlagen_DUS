using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiederholungOOP
{
    class Fahrzeug
    {
        public Fahrzeug(IMotor motor, IBremssystem bremse)
        {
            this.motor = motor;
            this.bremse = bremse;
        }

        private IMotor motor;
        private IBremssystem bremse;

        public string Fahrer { get; set; }
        public int AktuelleGeschwindigkeit { get; private set; }
        public int Kilometerstand { get; private set; }

        public void Fahren(int Stunden)
        {
            if (Stunden > 0)
                Kilometerstand += AktuelleGeschwindigkeit * Stunden;
            else
                throw new ArgumentException("Ungültiger Wert in Stunden");
        }

        public void Beschleunigen()
        {
            AktuelleGeschwindigkeit = motor.Beschleunigen(AktuelleGeschwindigkeit);
        }
        public void Bremsen()
        {
            AktuelleGeschwindigkeit = bremse.Bremsen(AktuelleGeschwindigkeit);
        }
    }

    interface IMotor 
    {
        // Zielvorgabe:
        // Konstruktor, der die Max. mögliche Geschindigkeit vorgibt
        // Beschleunigungswert selber in der Klasse aussuchen
        // Kein "negatives Beschleunigen"
        int Beschleunigen(int alterWert);
    }

    interface IBremssystem
    {
        // Zielvorgabe:
        // Bremswert in der Klasse selbst aussuchen
        // -> Cap auf 0
        int Bremsen(int alterWert);
    }
}
