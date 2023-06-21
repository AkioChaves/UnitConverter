using System.Globalization;

namespace UnitConverterCSharp.Services
{
    //Class responsable to convert the values
    internal class Converter
    {
        //Variable
        public double Result { get; set; }

        public void Converting(int num)
        {
            //Switch to determine what to convert and give the result
            switch(num)
            {
                case 1:
                    Console.Write("Celsius: ");
                    double celsius = double.Parse(Console.ReadLine());
                    Result = celsius * 1.8 + 32;
                    Console.WriteLine($"Fahrenheit: {Result.ToString("F2", CultureInfo.InvariantCulture)}°F.");
                    break;
                case 2:
                    Console.Write("Fahrenheit: ");
                    double fahrenheit = double.Parse(Console.ReadLine());
                    Result = (fahrenheit - 32) / 1.8;
                    Console.WriteLine($"Celsius: {Result.ToString("F2", CultureInfo.InvariantCulture)}°C.");
                    break;
                case 3:
                    Console.Write("Meters: ");
                    double meters = double.Parse(Console.ReadLine());
                    Result = meters * 3.28084;
                    Console.WriteLine($"Feet: {Result.ToString("F2", CultureInfo.InvariantCulture)}ft.");
                    break;
                case 4:
                    Console.Write("Feet: ");
                    double feet = double.Parse(Console.ReadLine());
                    Result = feet / 3.28084;
                    Console.WriteLine($"Meters: {Result.ToString("F2", CultureInfo.InvariantCulture)}m.");
                    break;
                case 5:
                    Console.Write("Kilograms: ");
                    double kilograms = double.Parse(Console.ReadLine());
                    Result = kilograms * 2.20462;
                    Console.WriteLine($"Pounds: {Result.ToString("F2", CultureInfo.InvariantCulture)}lbs.");
                    break;
                case 6:
                    Console.Write("Pounds: ");
                    double pounds = double.Parse(Console.ReadLine());
                    Result = pounds / 2.20462;
                    Console.WriteLine($"Pounds: {Result.ToString("F2", CultureInfo.InvariantCulture)}Kg.");
                    break;
                default:
                    Console.WriteLine("This value doesn't exist!");
                    break;
            }
        }
    }
}
