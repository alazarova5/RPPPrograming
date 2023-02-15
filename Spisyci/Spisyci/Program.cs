using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNum
{
    class Program
    {
        static void Main(string[] args)
        {
            //list of intiger numbers
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            //finding last element
            int last = nums.Last();

            //removing all like the last element
            nums.RemoveAll(x => x == last); 

            //print
            Console.WriteLine(string.Join(" ",nums));
            
        }
    }
}
