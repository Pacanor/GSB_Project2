using System;
using Multiply;
using SquareI;

namespace BasicCalculator
{
    public class BasicCalculator : IBasicCalculator, IMultiplying, ISquared1
    {
        public dynamic result;
        private readonly Multiplying Mul = new Multiplying();
        private readonly Squared1 Square = new Squared1();
        public dynamic Time(dynamic a, dynamic b)
        {
            result = Mul.Time(a, b);
            return result;
        }
        public dynamic Squarea(dynamic a)
        {
            result = Square.Squarea(a);
            return result;
        }
    }
}
