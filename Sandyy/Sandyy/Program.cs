using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandyy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0] == "PRINT")
                {
                    break;
                }
                string name = input[0];
                string city = input[1];

                if (!d.ContainsKey(city))
                {
                    d.Add(city, 1);
                }
                else
                {
                    d[city] ++;
                    
                }
            }
            Console.WriteLine($"Towns count: {d.Count()}");
            foreach (var item in d)
            {
               Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
