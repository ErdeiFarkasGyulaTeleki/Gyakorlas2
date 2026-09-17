using DiakApp;

Dictionary<Tantargy, double> atlagok1 = new Dictionary<Tantargy, double>
{
    { Tantargy.Magyar, 4.4 },
    { Tantargy.Matematika, 3.6 },
    { Tantargy.Angol, 2.1 }
};

Diak diak1 = new Diak("Tüdő R. Ákos", atlagok1);

Console.WriteLine(diak1);

diak1.TantargyAtlagokKiirasa();