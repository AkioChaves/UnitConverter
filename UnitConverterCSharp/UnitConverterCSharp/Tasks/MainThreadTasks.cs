using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverterCSharp.Handlers;

namespace UnitConverterCSharp.Tasks
{
    public static class MainThreadTasks
    {
        public static async Task<string> ReadInputInterval(int interval)
        {
            var input = Utility.Read<string>();

            if (input.ToLower() == "quit" || input.ToLower() == "exit")
            {
                return "Thank you for using Converter!";
            }

            await Task.Delay(interval * 1000);

            return input;
        }
        public static async Task Conversion()
        {
            await Task.Delay(0);
        }
    }
}
