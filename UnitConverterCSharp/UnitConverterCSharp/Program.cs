using System;
using System.Globalization;
using UnitConverterCSharp.Services;

class Program
{
    static void Main(string[] args)
    {
        //Calling the service to convert
        Converter Conv = new Converter();

        //Program apresentation
        Console.WriteLine("Welcome to Unit Converter!");
        Console.WriteLine("Select the following options to convert:");
        Console.WriteLine("1) To converte Celsius to Fahrenheit.");
        Console.WriteLine("2) To converte Fahrenheit to Celsius.");
        Console.WriteLine("3) To converte Meters to Feet.");
        Console.WriteLine("4) To converte Feet to Meters.");
        Console.WriteLine("5) To converte Kilograms to Pounds.");
        Console.WriteLine("6) To converte Pounds to Kilograms.");

        //Receiver to know what value convert
        int input = int.Parse(Console.ReadLine());
        Conv.Converting(input);
    }
}