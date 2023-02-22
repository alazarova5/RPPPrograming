using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double zaplata = double.Parse(Console.ReadLine());
            if(zaplata>=610)
                {
                Console.WriteLine("16");
            }
            else
            {
                double osigurovka = zaplata * 5 %;
                Console.WriteLine(osigurovka);
            }
           
        }
    }
}
