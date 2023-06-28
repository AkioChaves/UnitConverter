using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverterCSharp.Interfaces;

namespace UnitConverterCSharp.Models
{
    public class Weight: IResponse<Weight>
    {
        public Weight() { }
        public Weight(double weight) { }
        public Weight(int input, bool isKilogram) { }

        public Weight From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Weight To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string[] ResultAwsner { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string[] Question => throw new NotImplementedException();

        public string[] Options => throw new NotImplementedException();

        public string[] Awsner { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string InitialMessage()
        {
            throw new NotImplementedException();
        }
    }
}
