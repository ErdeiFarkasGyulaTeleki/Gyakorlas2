using System.Security.Cryptography;

namespace DiakApp
{
    public class DiakGenerator
    {
        public class DiakGeneratorKonfig
        {
            public double haromnevuek_eselye;
            public List<string> VezetekNevek;
            public List<string> KeresztNevek;

            public DiakGeneratorKonfig(double _arany, List<string> _vezetek, List<string> _kereszt)
            {
                haromnevuek_eselye = _arany;
                VezetekNevek = _vezetek;
                KeresztNevek = _kereszt;
            }

            public class Epito
            {
                public double haromnevuek_eselye = 0.15;
                public List<string> VezetekNevek = new List<string>() { "Kovács", "Nagy", "Tóth", "Szabó", "Horváth", "Varga", "Kiss", "Molnár", "Balogh", "Farkas" };
                public List<string> KeresztNevek = new List<string>() { "Bence", "Levente", "Máté", "Dávid", "Gergő", "Zsombor", "Ádám", "Bálint", "Márk", "Tamás" };

                public Epito SetMagyarHaromnevuekAranya(double aranya)
                {
                    haromnevuek_eselye = aranya;
                    return this;
                }

                public Epito SetVezetekNevek(List<string> vezetekNevek)
                {
                    VezetekNevek = vezetekNevek;
                    return this;
                }

                public Epito AddVezetekNev(string vezetekNev)
                {
                    VezetekNevek.Add(vezetekNev);
                    return this;
                }

                public Epito AddVezetekNevek(List<string> vezetekNevek)
                {
                    VezetekNevek.AddRange(vezetekNevek);
                    return this;
                }

                public Epito SetKeresztNevek(List<string> keresztNevek)
                {
                    KeresztNevek = keresztNevek;
                    return this;
                }

                public Epito AddKeresztNev(string keresztNev)
                {
                    KeresztNevek.Add(keresztNev);
                    return this;
                }

                public Epito AddKeresztNevek(List<string> keresztnevek)
                {
                    KeresztNevek.AddRange(keresztnevek);
                    return this;
                }

                public DiakGeneratorKonfig KonfigEpites()
                {
                    return new DiakGeneratorKonfig(haromnevuek_eselye, VezetekNevek, KeresztNevek);
                }
            }
        }

        public static readonly DiakGeneratorKonfig.Epito epito = new DiakGeneratorKonfig.Epito()
            .AddVezetekNev("Erdei")
            .AddKeresztNev("Farkas")
            .AddKeresztNev("Gyula");


        public static readonly DiakGeneratorKonfig alapKonfig = epito.KonfigEpites();


        public static Diak UjDiak()
        {
            Random random = new Random();

            string nev = NevGeneralas(random);
            Dictionary<Tantargy, double> atlagok = AtlagokGeneralas(random);

            return new Diak(nev, atlagok);
        }

        private static string NevGeneralas(Random random)
        {
            public List<string> VezetekNevek = alapKonfig.VezetekNevek;
            public List<string> KeresztNevek = alapKonfig.KeresztNevek;


            string vezetekNev = VezetekNevek[random.Next(0, VezetekNevek.Count)];
            string keresztNev = KeresztNevek[random.Next(0, KeresztNevek.Count)];

            if (random.NextDouble() < MAGYAR_HAROMNEVUEK_ARANYA)
            {
                while (true)
                {
                    string masodikKeresztNev = KeresztNevek[random.Next(0, KeresztNevek.Count)];
                    if (masodikKeresztNev != keresztNev)
                    {
                        keresztNev += " " + masodikKeresztNev;
                        break;
                    }
                }
            }

            return vezetekNev + " " + keresztNev;
        }

        private static Dictionary<Tantargy, double> AtlagokGeneralas(Random random)
        {
            Dictionary<Tantargy, double> atlagok = new Dictionary<Tantargy, double>();

            foreach (Tantargy tantargy in Enum.GetValues(typeof(Tantargy)))
            {
                double atlag = Math.Round(random.NextDouble() * 5, 2);
                atlagok.Add(tantargy, atlag);
            }

            return atlagok;
        }
    }
}
