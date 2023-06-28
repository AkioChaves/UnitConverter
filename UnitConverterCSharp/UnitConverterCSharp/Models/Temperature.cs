using UnitConverterCSharp.Data;
using UnitConverterCSharp.Interfaces;

namespace UnitConverterCSharp.Models
{
    public class Temperature : IConvertHandler<TemperatureType>, 
    {
        #region Variables
        public double Kelvin { get; private set; }
        public double Fahrenheit
        {
            get => Celsius * 9 / 5 + 32;
            set => Celsius = (value - 32) * 5 / 9;
        }
        public double Celsius
        {
            get => Kelvin - 273.15;
            set => Kelvin = value + 273.15;
        }


        public string[] Question
        {
            get
            {
                return new string[] { "Want to convert Temperature From: ", "To:" };
            }
        }
        public string[] Options
        {
            get
            {
                return new string[] { "1) Kelvin", "2) Fahrenheit", "3) Celsius" };
            }
        }
        public string[] Awsner
        {
            get
            {
                return new string[] { "Temperature is converted from {0} to {1} and the result is: {2}" };
            }
        }
        #endregion

        public Temperature() 
        {
           
        }
        public Temperature(double kelvin)
        {
            Kelvin = kelvin;
        }
        public Temperature(double temperature, TemperatureType unit)
        {
            ConvertFrom(temperature, unit);
        }

        public TemperatureType ConvertTo(TemperatureType value)
        {
            throw new NotImplementedException();
        }
        public void ConvertFrom(double unit, TemperatureType value)
        {
            throw new NotImplementedException();
        }

    }
}
