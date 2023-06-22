using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverterCSharp.Models
{
    internal class Temperature : Converter
    {
        public void ConvertTemperature()
        {
            WriteInput("Celsius", "Fahrenheit", "Kelvin");
            int input = ReadInputInt();

            switch (input)
            {
                case 1:
                    CelsiusToFahrenheit();
                    break;
                case 2:
                    CelsiusToKelvin();
                    break;
                case 3:
                    FahrenheitToCelsius();
                    break;
                case 4:
                    FahrenheitToKelvin();
                    break;
                case 5:
                    KelvinToCelsius();
                    break;
                case 6:
                    KelvinToFahrenheit();
                    break;
                default:
                    break;
            }

        }

        //Convert Celsius to Fahrenheit
        public virtual void CelsiusToFahrenheit()
        {
            Console.Write("Enter the number of Celsius: ");
            double celsius = ReadInputDouble();
            double fahrenheit = ConvertAdd(celsius * 1.8, 32);
            WriteResult(celsius.ToString("F2", CultureInfo.InvariantCulture) + "°C", fahrenheit.ToString("F2", CultureInfo.InvariantCulture) + "°F.");
        }

        //Convert Celsius to Kelvin
        public virtual void CelsiusToKelvin()
        {
            Console.Write("Enter the number of Celsius: ");
            double celsius = ReadInputDouble();
            double kelvin = ConvertAdd(celsius, 273.15);
            WriteResult(celsius.ToString("F2", CultureInfo.InvariantCulture) + "°C", kelvin.ToString("F2", CultureInfo.InvariantCulture) + "°K.");
        }

        //Convert Fahrenheit to Celsius
        public virtual void FahrenheitToCelsius()
        {
            Console.Write("Enter the number of Fahrenheit: ");
            double fahrenheit = ReadInputDouble();
            double celsius = ConvertDivide(fahrenheit - 32, 1.8);
            WriteResult(fahrenheit.ToString("F2", CultureInfo.InvariantCulture) + "°F", celsius.ToString("F2", CultureInfo.InvariantCulture) + "°C.");
        }

        //Convert Fahrenheit to Kelvin
        public virtual void FahrenheitToKelvin()
        {
            Console.Write("Enter the number of Fahrenheit: ");
            double fahrenheit = ReadInputDouble();
            double kelvin = ConvertAdd((fahrenheit - 32) * 5 / 9, 273.15);
            WriteResult(fahrenheit.ToString("F2", CultureInfo.InvariantCulture) + "°F", kelvin.ToString("F2", CultureInfo.InvariantCulture) + "°C.");
        }

        //Convert Kelvin to Celsius
        public virtual void KelvinToCelsius()
        {
            Console.Write("Enter the number of Kelvin: ");
            double kelvin = ReadInputDouble();
            double celsius = ConvertSub(kelvin, 273.15);
            WriteResult(kelvin.ToString("F2", CultureInfo.InvariantCulture) + "°F", celsius.ToString("F2",CultureInfo.InvariantCulture) + "°C.");
        }

        //Convert Kelvin to Fahrenheit
        public virtual void KelvinToFahrenheit()
        {
            Console.Write("Enter the number of Kelvin: ");
            double kelvin = ReadInputDouble();
            double fahrenheit = ConvertMultiply(kelvin - 273.15, 1.8);
            WriteResult(kelvin.ToString("F2", CultureInfo.InvariantCulture) + "°F", fahrenheit.ToString("F2", CultureInfo.InvariantCulture) + "°C.");
        }


        public void Aleluia()
        {
            StringBuilder stringBuilder = new StringBuilder();
            string[] temperatures = new string[] { "Celsius", "Fahrenheit", "Kelvins" };
            stringBuilder.AppendLine($"You want to convert:");
            stringBuilder.AppendLine($"1) {temperatures[0]} to {temperatures[1]}.");
            stringBuilder.AppendLine($"2) {temperatures[0]} to {temperatures[2]}.");
            stringBuilder.AppendLine($"3) {temperatures[1]} to {temperatures[0]}.");
            stringBuilder.AppendLine($"4) {temperatures[1]} to {temperatures[2]}.");
            stringBuilder.AppendLine($"5) {temperatures[2]} to {temperatures[0]}.");
            stringBuilder.AppendLine($"6) {temperatures[2]} to {temperatures[1]}.");

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
