using System;
using System.Collections.Generic;
using System.Linq;

namespace Mniplation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string cmd = input[0];
                if (cmd == "print")
                {
                    break;
                }

                switch (cmd)
                {
                    case "add":
                        {
                            var index = int.Parse(input[1]);
                            var element = int.Parse(input[2]);
                            nums.Insert(index, element);
                            break;
                        }

                    case "addMany":
                        {
                            int index = int.Parse(input[1]);
                            for (int i = input.Count() - 1; i >= 2; i--)
                            {
                                nums.Insert(index, int.Parse(input[i]));
                            }
                            break;
                        }


                    case "contains":
                        {
                            int element = int.Parse(input[1]);
                            Console.WriteLine(nums.IndexOf(element));
                            break;
                        }

                    case "remove":
                        {
                            int index = int.Parse(input[1]);
                            nums.RemoveAt(index);
                            break;
                        }

                    case "shift":
                        {
                            var pos = int.Parse(input[1]);
                            for (int i = 0; i < pos%nums.Count(); i++)
                            {
                                int element = nums[0];
                                nums.RemoveAt(0);
                                nums.Add(element);
                            }

                            break;
                        }

                    case "sumPairs":
                        {
                            List<int> result = new List<int>();
                            for (int i = 0; i < nums.Count; i=i+2)
                            {
                                result.Add(nums[i] + nums[i + 1]);
                            }
                            nums = result;
                            break;
                        }

                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
