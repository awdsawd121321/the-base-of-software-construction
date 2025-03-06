using System;

namespace ArrayStatsProgram
{
    class Program
    {
        static void Main()
        {
            int[] array = GetUserInputArray();
            var arrayStats = CalculateArrayStats(array);
            PrintArrayStats(arrayStats);
        }

        static int[] GetUserInputArray()
        {
            Console.Write("请输入数组元素，以空格分隔: ");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            int[] array = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                array[i] = int.Parse(inputArray[i]);
            }
            return array;
        }

        static (int Max, int Min, double Average, int Sum) CalculateArrayStats(int[] array)
        {
            int max = array[0];
            int min = array[0];
            int sum = 0;
            foreach (var num in array)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
                sum += num;
            }
            double average = (double)sum / array.Length;
            return (max, min, average, sum);
        }

        static void PrintArrayStats((int Max, int Min, double Average, int Sum) stats)
        {
            Console.WriteLine($"数组最大值: {stats.Max}");
            Console.WriteLine($"数组最小值: {stats.Min}");
            Console.WriteLine($"数组平均值: {stats.Average}");
            Console.WriteLine($"数组元素总和: {stats.Sum}");
        }
    }
}