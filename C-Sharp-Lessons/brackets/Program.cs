﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsTrueBrackets(Console.ReadLine()).ToString());
        }

        private static bool IsTrueBrackets(string inp)
        {
            string list = new string( inp.Where(t => (t == '(' || t == ')' || t == '{' || t == '}' ||
                                                      t == '<' || t == '>' || t == '[' || t == ']')).ToArray());

            while (list.Contains("()") || list.Contains("{}") || list.Contains("<>") || list.Contains("[]"))
            {
                list = list.Replace("()", ""); list = list.Replace("{}", "");
                list = list.Replace("<>", ""); list = list.Replace("[]", "");
            }
            return list.Length == 0;
        }
    }
}
