using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverterCSharp.Models
{
    internal class Weight : Converter
    {
        public void ConvertWeight()
        {
            WriteInput("Kilograms", "Pounds");
            Console.Write("Type the selected number: ");
            int input = ReadInputInt();
            Console.WriteLine();

            switch (input)
            {
                case 1:
                    KilogramsToPounds();
                    break;
                case 2:
                    PoundsToKilograms();
                    break;
                default:
                    break;
            }
        }

        //Convert Kilograms to Pounds
        public void KilogramsToPounds()
        {
            Console.Write("Enter the number of Kilograms: ");
            double kilograms = ReadInputDouble();
            double pounds = ConvertMultiply(kilograms, 2.20462);
            WriteResult(kilograms.ToString("F2", CultureInfo.InvariantCulture) + "Kg", pounds.ToString("F2", CultureInfo.InvariantCulture) + "lbs.");
        }

        //Convert Pounds to Kilograms
        public void PoundsToKilograms()
        {
            Console.Write("Enter the number of Pounds: ");
            double pounds = ReadInputDouble();
            double kilograms = ConvertDivide(pounds, 2.20462);
            WriteResult(pounds.ToString("F2", CultureInfo.InvariantCulture) + "lbs", kilograms.ToString("F2", CultureInfo.InvariantCulture) + "Kg.");
        }
    }
}
