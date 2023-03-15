using System;
using System.Collections.Generic;
using System.Linq;

namespace Minyor
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line=="stop")
                {
                    break;
                }
                int n = int.Parse(Console.ReadLine());
                dict.Add(line, n);
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
