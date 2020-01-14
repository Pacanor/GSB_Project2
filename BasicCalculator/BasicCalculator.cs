using System;
using Multiply;

namespace BasicCalculator
{
    public interface IBasicCalculator 
    {
        public dynamic Time(dynamic a, dynamic b);
    }
    public class BasicCalculator : IBasicCalculator, IMultiplying
    {
        public dynamic result;
        Multiplying mul = new Multiplying();
        public dynamic Time(dynamic a, dynamic b)
        {
            result = mul.Time(a, b);
            return result;
        }
    }
}
