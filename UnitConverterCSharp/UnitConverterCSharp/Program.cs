using UnitConverterCSharp.Constants;
using UnitConverterCSharp.Handlers;
using UnitConverterCSharp.Models;

class Program
{
    public static async Task Main()
    {
        foreach (string text in Strings.INITIAL_TEXT) { Utility.Write(text); }

        Converter convert = new Converter();

        await convert.Initialize();
    }

}