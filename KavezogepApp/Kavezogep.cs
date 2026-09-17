namespace KavezogepApp
{
    public class Kavezogep
    {
        private int vizKeszletMl;

        public Kavezogep(int _vizKeszletMl)
        {
            vizKeszletMl = _vizKeszletMl;
        }

        public void VizTolt(int ml)
        {
            if (ml < 1)
            {
                Console.WriteLine("A töltött víz mennyisége csak pozitív lehet!");
                return;
            }

            vizKeszletMl += ml;

            Console.WriteLine($"Sikeresen töltött {ml} ml vizet.");
        }   

        public void KaveFozes()
        {
            if (vizKeszletMl < 150)
            {
                Console.WriteLine("Nem lehet 150 ml-nél kevesebb vízből kávét főzni!");
                return;
            }

            vizKeszletMl -= 150;

            Console.WriteLine("Sikeres kávéfőzés!");
        }

        public override string ToString()
        {
            return $"A kávégépben {vizKeszletMl} ml víz van.";
        }
    }
}
