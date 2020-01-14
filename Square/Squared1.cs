using System;
using BasicOps;

namespace SquareI
{
    public interface ISquared1
    {
        public dynamic Squarea(dynamic a);
    }
    public class Squared1: ISquared1
    {
        public dynamic result;
        public dynamic Squarea(dynamic a)
        {
            result = Square.Squared(a);
            return result;
        }
    }
}
