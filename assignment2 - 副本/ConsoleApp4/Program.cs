using System;

namespace ToeplitzMatrixProgram
{
    class Program
    {
        static void Main()
        {
            int[,] matrix = GetUserInputMatrix();
            bool isToeplitz = IsToeplitzMatrix(matrix);
            PrintToeplitzResult(isToeplitz);
        }

        static int[,] GetUserInputMatrix()
        {
            Console.Write("请输入矩阵的行数: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("请输入矩阵的列数: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            Console.WriteLine("请逐行输入矩阵元素，每行元素用空格分隔：");
            for (int i = 0; i < rows; i++)
            {
                string[] rowInput = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(rowInput[j]);
                }
            }

            return matrix;
        }

        static bool IsToeplitzMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] != matrix[i - 1, j - 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void PrintToeplitzResult(bool isToeplitz)
        {
            Console.WriteLine($"该矩阵是否为托普利茨矩阵: {isToeplitz}");
        }
    }
}