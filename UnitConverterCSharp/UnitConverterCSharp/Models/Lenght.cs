using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverterCSharp.Models
{
    internal class Lenght : Converter
    {
        //Validation for what measure convert
        public void ConvertLenght()
        {
            WriteInput("Meters", "Feet");
            Console.Write("Type the selected number: ");
            int input = ReadInputInt();
            Console.WriteLine();

            switch (input)
            {
                case 1:
                    MetersToFeet();
                    break;
                case 2:
                    FeetToMeters();
                    break;
                default:
                    break;
            }
        }

        //Convert Meters to Feet
        public void MetersToFeet()
        {
            Console.Write("Enter the number of Meters: ");
            double meters = ReadInputDouble();
            double feet = ConvertMultiply(meters, 3.28084);
            WriteResult(meters.ToString("F2", CultureInfo.InvariantCulture) + "m", feet.ToString("F2", CultureInfo.InvariantCulture) + "ft.");
        }

        //Convert Feet to Meters
        public void FeetToMeters()
        {
            Console.Write("Enter the number of Feets: ");
            double feet = ReadInputDouble();
            double meters = ConvertDivide(feet, 3.28084);
            WriteResult(feet.ToString("F2", CultureInfo.InvariantCulture) + "ft", meters.ToString("F2", CultureInfo.InvariantCulture) + "m.");
        }
    }
}
