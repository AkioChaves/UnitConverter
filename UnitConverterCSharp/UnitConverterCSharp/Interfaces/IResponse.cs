using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverterCSharp.Interfaces
{
    public interface IResponse<T>
    {
        public string[] Question { get; }
        public string[] Options { get; } 
        public string[] Awsner { get; }
        public void Result(string str);
        T From { get; set; }
        T To { get; set; }

    }
}
