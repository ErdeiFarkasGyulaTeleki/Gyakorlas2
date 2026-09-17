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
    }
}
