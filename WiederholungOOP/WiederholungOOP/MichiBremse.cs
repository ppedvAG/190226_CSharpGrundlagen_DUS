namespace WiederholungOOP
{
    internal class MichiBremse : IBremssystem
    {
        private const int Bremswert = 30;
        public int Bremsen(int alterWert)
        {
            if (alterWert - Bremswert > 0)
                return alterWert - Bremswert;
            else
                return 0;
        }
    }
}