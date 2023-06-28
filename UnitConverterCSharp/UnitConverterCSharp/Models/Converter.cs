using System.Globalization;
using System.Text;
using UnitConverterCSharp.Data;
using UnitConverterCSharp.Handlers;
using UnitConverterCSharp.Interfaces;

namespace UnitConverterCSharp.Models
{
    public class Converter
    {
        public Converter() { }
        public async Task Initialize()
        {
            while (true)
            {
                var input = Utility.Read<int>();

                await Convert((ConvertType)input);
            }
        }
        public async Task Convert(ConvertType type)
        {
            switch (type)
            {
                case ConvertType.Temperature:
                    TemperatureType temp = new TemperatureType();
                    await Conversion(temp);
                    break;
                case ConvertType.Distance:
                    Distance distance = new Distance();
                    await Conversion(distance);
                    break;
                case ConvertType.Weight:
                    Weight weight = new Weight();
                    await Conversion(weight);
                    break;
            }

            await Task.Delay(0);
        }
        public async Task<IResponse<T>> Conversion<T>(IResponse<T> response)
        {
            Utility.Write(response.Question[0]);
            Utility.Write(response.Options);

            int fromValue = Utility.Read<int>();
            response.From = (T)Enum.Parse(typeof(T), fromValue.ToString());

            Utility.Write(response.Question[1]);
            Utility.Write(response.Options);

            int toValue = Utility.Read<int>();
            response.To = (T)Enum.Parse(typeof(T), toValue.ToString());

            Utility.Write(response.Question[2]);

            //response.Result();

            await Task.Delay(1 * 1000);

            Utility.Write("To restart type R or restart");

            return response;
        }

    }
}
