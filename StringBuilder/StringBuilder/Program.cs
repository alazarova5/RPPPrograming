﻿using System;
using System.Text;

namespace SB
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                sb.Append((char)(text[i] + 3));
            }
            Console.WriteLine(sb);
        }
    }
}
