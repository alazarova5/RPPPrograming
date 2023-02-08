using System;

namespace StatisticArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Count = "+OptionsManager.CountLess100(arr));
            Console.WriteLine("Max = "+OptionsManager.MaxNum(arr));
            OptionsManager.EvenNums(arr);
            arr = OptionsManager.ReverseArr(arr);
            Console.WriteLine("Sum = "+OptionsManager.SumEvenNums(arr));
            Console.WriteLine("Count ="+OptionsManager.CountEvenNums(arr));
            OptionsManager.PrintArr(arr);
        }
    }
}
