using System;
using System.Collections.Generic;
using System.Text;
using BasicOps;

namespace Divisions
{
    public class getDivide
    {
        public class DivisionInterface : IDivide
        {
            public dynamic result;

            public dynamic Divide(dynamic a, dynamic b)
            {
                result = Division.Quotient(a, b);
                return result;
            }

            public dynamic Divide(dynamic a)
            {
                result = Division.Quotient(a);
                return result;
            }
        }
    }
}

