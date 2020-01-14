using System;
using BasicOps;
namespace Subtract
{
    public class Subtractby : ISubtractby
    {
        public dynamic result;
        public dynamic Subtracted(dynamic a, dynamic b)
        {
            result = Subtraction.Subtract(a, b);
            return result;
        }
    }
}
