using System;
using System.Collections.Generic;
using System.Text;
using BasicOps;

namespace StatisticOps
{
    public class StatVariance
    {
        public static dynamic result;
        public static dynamic Variance(dynamic arrayA)
        {

            dynamic theMean = StatMean.Mean(arrayA);
            dynamic arrayCount_1 = Helpers.Array.Length(arrayA) - 1;

            dynamic squares = new Array[0];
            dynamic squareSum = 0.0;
            dynamic differences = 0.0;


            foreach (dynamic a in arrayA)
            {
                differences = Subtraction.Difference(a, theMean);
                squares = Square.Squared(differences);
                squareSum = (squareSum + squares);
            }

            result = Division.Quotient(squareSum, arrayCount_1);
            return result;
        }
    }
}
