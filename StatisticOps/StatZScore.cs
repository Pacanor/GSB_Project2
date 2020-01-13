
using System;

namespace StatisticOps
{
    public class StatZScore
    {
        public static double ZScore(dynamic score, dynamic values)
        {
            double mean = StatMean.Mean(values);
            double[] squaredDeviation = new double[values.Length]; ;
            int i = 0;

            foreach (dynamic a in values)
            {
                dynamic dev = a-mean; 
                squaredDeviation[i] = dev*dev;
                i++;
            }
            double variance = StatMean.Mean(squaredDeviation);
            double standDev = Math.Pow(variance, 1.0 / 2.0);
            double zScore = (score - mean) / standDev;
            return zScore;
        }
    }
}