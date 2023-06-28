using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverterCSharp.Interfaces
{
    public interface IConvertHandler<T>
    {
        T ConvertTo(T value);
        void ConvertFrom(double unit, T value);

    }
}
