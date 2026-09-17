namespace FilmApp
{
    public class Film
    {
        public string Cim;
        public int HosszPercben;

        public Film(string _cim, int _hosszPercben)
        {
            Cim = _cim;
            HosszPercben = _hosszPercben;
        }

        public override string ToString()
        {
            return $"A {Cim} című film {HosszPercben} perces.";
        }
    }
}
