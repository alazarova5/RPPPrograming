using System;

namespace upr
{
    class Program
    {
        static void Main(string[] args)
        {
            double chislo = double.Parse(Console.ReadLine());
            if(chislo>=200)
            {
                double otstypka = (90 * chislo) / 100;
                Console.WriteLine(otstypka);
            }
            else
            {
                Console.WriteLine(chislo);
            }
        }
    }
}
