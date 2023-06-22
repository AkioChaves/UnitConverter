using System.Globalization;
using System.Text;

namespace UnitConverterCSharp.Models
{
    //Class responsable to convert the values
    public class Converter
    {
        public void Converting(int num)
        {
            //Validation
            switch (num)
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
                    Weight weight = new Weight();
                    weight.ConvertWeight();
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }

        //Read value for converting
        private protected double ReadInputDouble() => double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //Read input to selecting what measure to convert
        private protected int ReadInputInt() => int.Parse(Console.ReadLine());

        //Program apresentation
        public void ProgramApresentation()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Welcome to Unit Converter!");
            stringBuilder.AppendLine("Select the following options to convert:");
            stringBuilder.AppendLine("1) Tempetature.");
            stringBuilder.AppendLine("2) Distance.");
            stringBuilder.AppendLine("3) Weight.");
            stringBuilder.AppendLine("4) Lenght.");
            stringBuilder.AppendLine("5) Time.");

            Console.WriteLine(stringBuilder.ToString());
        }

        public virtual void WriteInput(params string[] measures)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int x = 1;
            stringBuilder.AppendLine($"You want to convert:");
            for (int i = 0; i < measures.Count(); i++)
            {
                for (int j = 0; j < measures.Count(); j++)
                {
                    if (i != j)
                    {
                        stringBuilder.AppendLine($"{x}) {measures[i]} to {measures[j]}.");
                        x++;
                    }
                }
            }
            Console.WriteLine(stringBuilder.ToString());
        }

        //Write the result
        private protected void WriteResult(string input, string result)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(input);
            stringBuilder.Append(" is equal to ");
            stringBuilder.Append(result);

            Console.WriteLine(stringBuilder.ToString());
        }

        //Math
        public double ConvertMultiply(double a, double b) => a * b;
        public double ConvertDivide(double a, double b) => a / b;
        public double ConvertAdd(double a, double b) => a + b;
        public double ConvertSub(double a, double b) => a - b;
    }
}
