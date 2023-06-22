using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using UnitConverterCSharp.Models;

class Program
{
    static void Main(string[] args)
    {
        //Calling the converter
        Converter Conv = new Converter();

        //Program apresentation
        Conv.ProgramApresentation();

        //Receiver to know what value convert
        Console.Write("Type the selected number: ");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine();

        //Validation
        Conv.Converting(input);

        Console.ReadLine();
        Console.Clear();
    }
}