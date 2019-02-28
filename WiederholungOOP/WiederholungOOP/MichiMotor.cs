namespace WiederholungOOP
{
    class MichiMotor : IMotor
    {
        private const int Beschleunigungswert = 22;
        public int Beschleunigen(int alterWert)
        {
            return alterWert + Beschleunigungswert; // ohne überprüfung
        }
    }
}