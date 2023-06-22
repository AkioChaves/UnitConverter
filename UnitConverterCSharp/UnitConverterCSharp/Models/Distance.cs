using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverterCSharp.Models
{
    internal class Distance : Converter
    {
        public void ConvertDistance()
        {
            WriteInput("Kilometers", "Miles");
            Console.Write("Type the selected number: ");
            int input = ReadInputInt();
            Console.WriteLine();

            switch (input)
            {
                case 1:
                    KilometersToMiles();
                    break;
                case 2:
                    MilesToKilometers();
                    break;
                default:
                    break;
            }
        }

        //Convert Kilometers to Miles
        public virtual void KilometersToMiles()
        {
            Console.Write("Enter the number of Kilometers: ");
            double kilometers = ReadInputDouble();
            double miles = ConvertDivide(kilometers, 1.609);
            WriteResult(kilometers.ToString("F2", CultureInfo.InvariantCulture) + " km", miles.ToString("F2", CultureInfo.InvariantCulture) + " miles.");
        }

        //Convert Miles to Kilometers
        public virtual void MilesToKilometers()
        {
            Console.Write("Enter the number of Miles: ");
            double miles = ReadInputDouble();
            double kilometers = ConvertMultiply(miles, 1.609);
            WriteResult(miles.ToString("F2", CultureInfo.InvariantCulture) + " miles", kilometers.ToString("F2", CultureInfo.InvariantCulture) + " km.");
        }
    }
}

