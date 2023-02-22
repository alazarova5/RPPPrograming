using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num == 1) Console.WriteLine("one");
            else if (num == 2) Console.WriteLine("two");
            else if (num==3) Console.WriteLine("three");
            else Console.WriteLine("number too big");

        }
    }
}
