using System;

namespace myspace.Data
{
    public class CounterSaver
    {
        public long Counter { get; set; }


        public (long primeValue, double Time) Calculation(long number)
        {
            var sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            while (true)
            {
                bool isPrime = true;
                //increment the number by 1 each time
                number = number + 1;

                long squaredNumber = (long)Math.Sqrt(number);

                //start at 2 and increment by 1 until it gets to the squared number
                for (long i = 2; i <= squaredNumber; i++)
                {
                    //how do I check all i's?
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    sw.Stop();
                    return (number, sw.Elapsed.TotalMilliseconds);
                }
            }
        }

        public static bool IsPrime(long number)
        {
            if (number < 2) return false;
            if (number % 2 == 0) return (number == 2);
            int root = (int)Math.Sqrt((double)number);
            for (int i = 3; i <= root; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public (long primeValue, double Time) CalculationFaster(long number)
        {
            var sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            while (true)
            {
                //increment the number by 1 each time
                number = number + 1;

                if (IsPrime(number))
                {
                    sw.Stop();
                    return (number, sw.Elapsed.TotalMilliseconds);
                }
            }
        }

        public long CountPrimes(int milliseconds)
        {
            var sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            long number = 0;
            long highestPrime = 0;

            while (sw.ElapsedMilliseconds < milliseconds)
            {
                bool isPrime = true;
                //increment the number by 1 each time
                number = number + 1;

                long squaredNumber = (long)Math.Sqrt(number);

                //start at 2 and increment by 1 until it gets to the squared number
                for (long i = 2; i <= squaredNumber; i++)
                {
                    if (sw.ElapsedMilliseconds < milliseconds)
                    {
                        break;
                    }

                    //how do I check all i's?
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    highestPrime = number;
                }
            }

            sw.Stop();

            return highestPrime;
        }
    }
}
