using System;
using System.Collections.Generic;

namespace SieveOfEratosthenesProgram
{
    class Program
    {
        static void Main()
        {
            int limit = 100;
            var primes = SieveOfEratosthenes(limit);
            PrintPrimes(primes);
        }

        static List<int> SieveOfEratosthenes(int n)
        {
            bool[] isPrime = new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
                isPrime[i] = true;
            }
            for (int p = 2; p * p <= n; p++)
            {
                if (isPrime[p])
                {
                    for (int i = p * p; i <= n; i += p)
                    {
                        isPrime[i] = false;
                    }
                }
            }
            List<int> primes = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i])
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        static void PrintPrimes(List<int> primes)
        {
            Console.Write("2~100 以内的素数为: ");
            foreach (var prime in primes)
            {
                Console.Write(prime + " ");
            }
            Console.WriteLine();
        }
    }
}
