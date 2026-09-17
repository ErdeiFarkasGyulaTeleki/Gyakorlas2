using TelefonApp;

Okostelefon telefon1 = new Okostelefon("Samsung Galaxy S21", 75);
Okostelefon telefon2 = new Okostelefon("iPhone 13", 50);

Console.WriteLine(telefon1);

telefon1.Toltottseg = -24;
Console.WriteLine(telefon1);

telefon1.Toltottseg = 134;
Console.WriteLine(telefon1);

telefon1.Toltottseg = 68;
Console.WriteLine(telefon1);
