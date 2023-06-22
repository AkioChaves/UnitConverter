using System;
using System.Globalization;
using UnitConverterCSharp.Models;

class Program
{
    static void Main(string[] args)
    {
        //Calling the converter
        Converter Conv = new Converter();

        while (true)
        {
            //Program apresentation
            Conv.ProgramApresentation();

            //Receiver to know what value convert
            int input = int.Parse(Console.ReadLine());

            //Validation
            switch (input)
            {
                case 1:
                    Temperature temperature = new Temperature();
                    temperature.ConvertTemperature();
                    break;
                case 2:
                    Distance distance = new Distance();
                    distance.ConvertDistance();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}