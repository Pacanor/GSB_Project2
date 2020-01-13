using System;

namespace RandomGenerator
{
    public class RandomGen
    {
        private static readonly Random random = new Random();

        public int RandomInt()
        {
            return random.Next();
        }
        public double RandomDouble()
        {
            return random.NextDouble() * random.Next();
        }
        public int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }

        public double RandomNumber(double min, double max)
        {
            int minInt = Convert.ToInt32(min);
            int maxInt = Convert.ToInt32(max);
            double number = random.NextDouble() * random.Next(minInt, maxInt);
            return number;
        }
        
        public double[] RandomDoubles(int num)
        {
            double[] numbers = new double[num];
            int i = 0;
            while (i < num)
            {
                numbers[i] = random.Next() * random.NextDouble();
            }
            return numbers;
        }

        public int[] RandomInts(int num)
        {
            int[] numbers = new int[num];
            int i = 0;
            while (i < num)
            {
                numbers[i] = random.Next();
            }
            return numbers;
        }

        public double[] RandomDoubles(int num, double min, double max)
        {
            int minInt = Convert.ToInt32(min);
            int maxInt = Convert.ToInt32(max);
            double[] numbers = new double[num];
            int i = 0;
            while (i < num)
            {
                numbers[i] = random.Next(minInt, maxInt) * random.NextDouble();
            }
            return numbers;
        }

        public static int[] RandomInts(int num, int min, int max)
        {
            int[] numbers = new int[num];
            int i = 0;
            while (i < num)
            {
                numbers[i] = random.Next(min, max);
            }
            return numbers;
        }

    }
}
