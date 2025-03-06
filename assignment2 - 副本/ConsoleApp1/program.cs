using System;
using System.Collections.Generic;

namespace PrimeFactorsProgram
{
    class Program
    {
        static void Main()
        {
            Console.Write("请输入一个整数: ");
            int number = int.Parse(Console.ReadLine());
            var primeFactors = GetPrimeFactors(number);
            Console.Write($"该数的素数因子为: ");
            foreach (var factor in primeFactors)
            {
                Console.Write(factor + " ");
            }
            Console.WriteLine();
        }

        static List<int> GetPrimeFactors(int number)
        {
            List<int> factors = new List<int>();
            for (int i = 2; i * i <= number; i++)
            {
                while (number % i == 0)
                {
                    factors.Add(i);
                    number /= i;
                }
            }
            if (number > 1)
            {
                factors.Add(number);
            }
            return factors;
        }
    }
}