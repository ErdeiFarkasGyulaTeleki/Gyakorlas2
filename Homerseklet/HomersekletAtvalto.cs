namespace Homerseklet
{
    public class HomersekletAtvalto
    {
        public double Celsius;

        public HomersekletAtvalto(double _celsius)
        {
            Celsius = _celsius;
        }

        public double ToFahrenheit()
        {
            return Celsius * 9 / 5 + 32;
        }

        public static double CelsiusToFahrenheit(double _celsius)
        {
            return _celsius * 9 / 5 + 32;
        }
    }
}
