namespace TelefonApp
{
    public class Okostelefon
    {
        public string Modell { get; set; }
        public int Toltottseg
        {
            get;
            set
            {
                field = Math.Clamp(value, 0, 100);
            }
        }

        public Okostelefon(string _modell, int _toltottseg)
        {
            Modell = _modell;
            Toltottseg = _toltottseg;
        }

        public override string ToString()
        {
            return $"A {Modell} telefon töltöttsége {Toltottseg}%";
        }
    }
}
