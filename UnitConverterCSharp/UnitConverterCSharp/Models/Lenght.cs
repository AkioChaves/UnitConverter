using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverterCSharp.Models
{
    internal class Lenght
    {

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
    }
}
