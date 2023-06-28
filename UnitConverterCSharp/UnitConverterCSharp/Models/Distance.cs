using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverterCSharp.Interfaces;

namespace UnitConverterCSharp.Models
{
    public class Distance : IResponse<Distance>
    {
        public Distance()
        {

        }

        public Distance(double input)
        {

        }


        public string[] ResultAwsner { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Distance To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string[] Question => throw new NotImplementedException();

        public string[] Options => throw new NotImplementedException();

        public string[] Awsner { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        Distance IResponse<Distance>.From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string InitialMessage()
        {
            throw new NotImplementedException();
        }
    }
}

