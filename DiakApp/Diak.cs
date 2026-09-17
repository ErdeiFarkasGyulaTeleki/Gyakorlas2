namespace DiakApp
{
    public class Diak
    {
        public string Nev;

        public Dictionary<Tantargy, double> atlagok;

        public Diak(string _nev, Dictionary<Tantargy, double> _atlagok)
        {
            Nev = _nev;
            atlagok = _atlagok;
        }

        public override string ToString()
        {
            return $"{Nev} nevű diák összátlaga: {Math.Round(atlagok.Values.Average(), 2)}";
        }

        public void TantargyAtlagokKiirasa()
        {
            Console.WriteLine($"{Nev} nevű diák tantárgyankénti átlaga:");
            atlagok.Select(t => $"\t{t.Key}: {Math.Round(t.Value, 2)}").ToList().ForEach(Console.WriteLine);
        }
    }
}
