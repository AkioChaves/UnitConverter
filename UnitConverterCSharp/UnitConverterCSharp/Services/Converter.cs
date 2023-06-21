using System.Globalization;

namespace UnitConverterCSharp.Services
{
    //Class responsable to convert the values
    internal class Converter
    {
        public void Converting(int num)
        {
            //Validation
            switch(num)
            {
                case 1:
                    CelsiusToFahrenheit();
                    break;
                case 2:
                    FahrenheitToCelsius();
                    break;
                case 3:
                    MetersToFeet();
                    break;
                case 4:
                    FeetToMeters();
                    break;
                case 5:
                    KilogramsToPounds();
                    break;
                case 6:
                    PoundsToKilograms();
                    break;
                default:
                    Console.WriteLine("This value doesn't exist!");
                    break;
            }
        }

        //Convert Celsius to Fahrenheit
        public void CelsiusToFahrenheit()
        {
            Console.Write("Enter the number of Celsius: ");
            double celsius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine($"{celsius.ToString(CultureInfo.InvariantCulture)}°C is equal to {fahrenheit.ToString(CultureInfo.InvariantCulture)}°F.");
        }

        //Convert Fahrenheit to Celsius
        public void FahrenheitToCelsius()
        {
            Console.Write("Enter the number of Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double celsius = (fahrenheit - 32) / 1.8;
            Console.WriteLine($"{fahrenheit.ToString(CultureInfo.InvariantCulture)}°F is equal to {celsius.ToString(CultureInfo.InvariantCulture)}°C.");
        }

        //Convert Meters to Feet
        public void MetersToFeet()
        {
            Console.Write("Enter the number of Meters: ");
            double meters = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double feet = meters * 3.28084;
            Console.WriteLine($"{meters.ToString(CultureInfo.InvariantCulture)}m is equal to {feet.ToString(CultureInfo.InvariantCulture)}ft.");
        }

        //Convert Feet to Meters
        public void FeetToMeters()
        {
            Console.Write("Enter the number of Feets: ");
            double feet = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double meters = feet / 3.28084;
            Console.WriteLine($"{feet.ToString(CultureInfo.InvariantCulture)}ft is equal to {meters.ToString(CultureInfo.InvariantCulture)}m.");
        }

        //Convert Kilograms to Pounds
        public void KilogramsToPounds()
        {
            Console.Write("Enter the number of Kilograms: ");
            double kilograms = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pounds = kilograms * 2.20462;
            Console.WriteLine($"{kilograms.ToString(CultureInfo.InvariantCulture)}Kg is equal to {pounds.ToString(CultureInfo.InvariantCulture)}lbs.");
        }

        //Convert Pounds to Kilograms
        public void PoundsToKilograms()
        {
            Console.Write("Enter the number of Pounds: ");
            double pounds = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double kilograms = pounds / 2.20462;
            Console.WriteLine($"{pounds.ToString(CultureInfo.InvariantCulture)}lbs is equal to {kilograms.ToString(CultureInfo.InvariantCulture)}Kg.");
        }
    }
}
