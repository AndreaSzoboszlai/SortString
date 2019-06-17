﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Microsoft .NET Framework 2.0 Application Development Foundation";
            string[] words = str.Split(' ');
            Array.Sort(words);
            for (int i = 0; i < words.Length; i++)
            {
            Console.WriteLine(words[i]);
            }

            string s;
            s = string.Join(" ", words);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
