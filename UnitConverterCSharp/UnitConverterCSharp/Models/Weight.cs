using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverterCSharp.Models
{
    internal class Weight
    {

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
