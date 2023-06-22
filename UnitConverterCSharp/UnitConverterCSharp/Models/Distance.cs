using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverterCSharp.Models
{
    internal class Distance : Converter
    {
        public virtual void ConvertDistance()
        {
            WriteInput("Kilometers", "Meters", "Centimeters");

        }
    }
}
