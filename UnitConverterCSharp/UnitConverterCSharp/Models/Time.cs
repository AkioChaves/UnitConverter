using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverterCSharp.Models
{
    internal class Time : Converter
    {
        //Validation for what measure convert
        public void ConvertTime()
        {
            WriteInput("Hours", "Minutes", "Seconds");
            Console.Write("Type the selected number: ");
            int input = ReadInputInt();
            Console.WriteLine();

            switch (input)
            {
                case 1:
                    HoursToMinutes();
                    break;
                case 2:
                    HoursToSeconds();
                    break;
                case 3:
                    MinutesToHours();
                    break;
                case 4:
                    MinutesToSeconds();
                    break;
                case 5:
                    SecondsToHours();
                    break;
                case 6:
                    SecondsToMinutes();
                    break;
                default:
                    break;
            }

        }

        //Convert Hours to Minutes
        public virtual void HoursToMinutes()
        {
            Console.Write("Enter the number of Hours: ");
            double hours = ReadInputDouble();
            double minutes = ConvertMultiply(hours, 60);
            WriteResult(hours.ToString("F2", CultureInfo.InvariantCulture) + " hours", minutes.ToString("F2", CultureInfo.InvariantCulture) + " minutes.");
        }

        //Convert Hours to Seconds
        public virtual void HoursToSeconds()
        {
            Console.Write("Enter the number of Hours: ");
            double hours = ReadInputDouble();
            double seconds = ConvertMultiply(hours, 3600);
            WriteResult(hours.ToString("F2", CultureInfo.InvariantCulture) + " hours", seconds.ToString("F2", CultureInfo.InvariantCulture) + " seconds.");
        }

        //Convert Minutes to Hours
        public virtual void MinutesToHours()
        {
            Console.Write("Enter the number of Minutes: ");
            double minutes = ReadInputDouble();
            double hours = ConvertDivide(minutes, 60);
            WriteResult(minutes.ToString("F2", CultureInfo.InvariantCulture) + " minutes", hours.ToString("F2", CultureInfo.InvariantCulture) + " hours.");
        }

        //Convert Minutes to Seconds
        public virtual void MinutesToSeconds()
        {
            Console.Write("Enter the number of Minutes: ");
            double minutes = ReadInputDouble();
            double seconds = ConvertAdd(minutes, 60);
            WriteResult(minutes.ToString("F2", CultureInfo.InvariantCulture) + " minutes", seconds.ToString("F2", CultureInfo.InvariantCulture) + " seconds.");
        }

        //Convert Seconds to Hours
        public virtual void SecondsToHours()
        {
            Console.Write("Enter the number of Seconds: ");
            double seconds = ReadInputDouble();
            double hours = ConvertDivide(seconds, 3600);
            WriteResult(seconds.ToString("F2", CultureInfo.InvariantCulture) + " seconds", hours.ToString("F2", CultureInfo.InvariantCulture) + " hours.");
        }

        //Convert Seconds to Minutes
        public virtual void SecondsToMinutes()
        {
            Console.Write("Enter the number of Seconds: ");
            double seconds = ReadInputDouble();
            double minutes = ConvertDivide(seconds, 60);
            WriteResult(seconds.ToString("F2", CultureInfo.InvariantCulture) + " seconds", minutes.ToString("F2", CultureInfo.InvariantCulture) + " minutes.");
        }
    }
}
