using System;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimension = int.Parse(Console.ReadLine());
            int rows = dimension;
            int colums = dimension;
            char[,] arr = new char[rows, colums];

            for (int i = 0; i < dimension; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    arr[i, j] = input[j];
                }
            }

            char nameriSimvol = char.Parse(Console.ReadLine());
            bool tyrsene = false;

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    if (arr[i, j] == nameriSimvol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        tyrsene = true;
                        break;
                    }
                }
            }
            if (!tyrsene)
            {
                Console.WriteLine($"{nameriSimvol} does not occur in the matrix");
            }
        }
    }
}