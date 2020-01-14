using System;
using System.Collections.Generic;
using System.Text;



namespace BasicCalculator
{
    public interface IBasicCalculator
    {
        public dynamic Time(dynamic a, dynamic b);
        public dynamic Squarea(dynamic a);
        public dynamic Subtracted(dynamic a, dynamic b);
        public dynamic SquareRoot(dynamic a);
        public dynamic Cubed(dynamic a);
    }
}
