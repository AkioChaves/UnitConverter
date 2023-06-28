using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnitConverterCSharp.Extension;

namespace UnitConverterCSharp.Handlers
{
    public static class Utility
    {
        public static T Read<T>() => (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
        public static void Write(string text) => Console.WriteLine(text);
        public static void Write(string[] multyText)
        {
            foreach ( string text in multyText) Write(text);
        }
        public static string GetNumbersOnly(string input)
        {
            string pattern = @"\d+";

            string numbersOnly = string.Empty;

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                numbersOnly += match.Value;
            }

            return numbersOnly;
        }
        public static T Multiply<T>(T a, T b) where T : struct
        {
            if (NumericExtensions.IsNumericType<T>())
            {
                dynamic x = a;
                dynamic y = b;
                return x * y;
            }
            else
            {
                throw new ArgumentException("Type T must be a numeric type.");
            }
        }
        public static T Divide<T>(T a, T b) where T : struct
        {
            if (NumericExtensions.IsNumericType<T>())
            {
                dynamic x = a;
                dynamic y = b;

                if (y == 0)
                    throw new DivideByZeroException();

                return x / y;
            }
            else
            {
                throw new ArgumentException("Type T must be a numeric type.");
            }
        }
        public static T Add<T>(T a, T b) where T : struct
        {
            if (NumericExtensions.IsNumericType<T>())
            {
                dynamic x = a;
                dynamic y = b;
                return x + y;
            }
            else
            {
                throw new ArgumentException("Type T must be a numeric type.");
            }
        }
        public static T Subtract<T>(T a, T b) where T : struct
        {
            if (NumericExtensions.IsNumericType<T>())
            {
                dynamic x = a;
                dynamic y = b;
                return x - y;
            }
            else
            {
                throw new ArgumentException("Type T must be a numeric type.");
            }
        }
    }
}
