using Homerseklet;

HomersekletAtvalto atvalto = new HomersekletAtvalto(25);

Console.WriteLine($"25 °C: {atvalto.ToFahrenheit()} °F");
Console.WriteLine($"38 °C: {HomersekletAtvalto.CelsiusToFahrenheit(38)} °F");