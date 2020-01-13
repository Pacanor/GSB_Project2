
namespace StatisticOps
{
    public class StatMean
    {
        public static dynamic Mean(dynamic values)
        {
            var sum = 0;
            foreach(dynamic a in values)
            {
                sum += a;
            }
            var mean = sum/ values.Length;
            return mean;
        }
    }
}