using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dim[0];
            int colums = dim[1];
            int[,] arr = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                int[] input = Console.ReadLine().Split(";").Select(int.Parse).ToArray();
                for (int j = 0; j <  colums; j++)
                {
                    arr[i, j] = input[j];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (arr[i,j]>20)
                    {
                        Console.WriteLine(arr[i, j]);
                    }
                }
            }
        }
    }
}

