using System;
using System.Collections.Generic;
using System.Globalization;

namespace ClassLibraryNumbers
{
    public static class Numbers
    {
        public static string FindPItoTheNthDigit(int n) => Math.PI.ToString(CultureInfo.InvariantCulture).Substring(0, n + 2);

        public static string FindEToTheNthDigit(int n) => Math.E.ToString(CultureInfo.InvariantCulture).Substring(0, n + 2);

        public static long FibonacciSequence(int n)
        {
            if (n <= 2)
            {
                return 1;
            }

            long[] l = new long[n];
            l[0] = 1;
            l[1] = 1;
            for (int i = 2; i < n; i++)
            {
                l[i] = l[i - 1] + l[i - 2];
            }

            return l[n - 1];
        }

        public static List<long> PrimeFactorization(long n)
        {
            List<long> l = new List<long> {1};
            for (long i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    l.Add(i);
                    n /= i;
                }
            }

            return l;
        }

        public static long NextPrimeNumber(int n)
        {
            long l= 1;
            List<long> list = new List<long>();
            int i = 0;
            while (n!=i)
            {
                l++;
                for (int j = 2; j <= l; j++)
                {
                    if ((l % j == 0))
                    {
                        if (l==j)
                        {
                            i++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return l;
        }
    }
}
