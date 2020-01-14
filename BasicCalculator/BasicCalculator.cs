using System;
using Multiply;
using SquareI;
using Subtract;
namespace BasicCalculator
{
    public class BasicCalculator : IBasicCalculator, IMultiplying, ISquared1,ISubtractby
    {
        public dynamic result;
        private readonly Multiplying Mul = new Multiplying();
        private readonly Squared1 Square = new Squared1();
        private readonly Subtractby Sub = new Subtractby();
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
        public dynamic Subtracted(dynamic a, dynamic b)
        {
            result = Sub.Subtracted(a, b);
            return result;
        }
    }
}
