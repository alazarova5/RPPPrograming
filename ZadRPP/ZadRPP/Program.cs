using System;
using System.Collections.Generic;
using System.Linq;

namespace ZadRPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string subject = input;
                if (!students.ContainsKey(subject))
                {
                    students.Add(subject, 1);
                }
                else
                {
                    students[subject]++;
                }
            }
        Console.WriteLine($"Subjects count: {students.Count()}");
            foreach (var item in students)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            
            }
        }
    }
}
