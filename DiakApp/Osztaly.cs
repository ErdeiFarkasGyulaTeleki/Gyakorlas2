namespace DiakApp
{
    public class Osztaly
    {
        public List<Diak> Diakok;

        public Osztaly(List<Diak> _diakok)
        {
            Diakok = _diakok;
        }

        public static Osztaly RandomOsztalyGeneralas(int _diakokSzama)
        {
            List<Diak> randomDiakok = new List<Diak>();
            for (int i = 0; i < _diakokSzama; i++)
            {
                randomDiakok.Add(DiakGenerator.UjDiak());
            }

            return new Osztaly(randomDiakok);
        } 
    }
}
