﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            FloatingPointInParentheses("dfjdhfjdhf(0.2569)=349edvin00385$%^{.6589}hakobfgj\"k<2569>cvcv$v[2365.]<5698.356hakob98>(25.56e5) ");
            Console.WriteLine(IsTrueBrackets(Console.ReadLine()).ToString());
        }

        private static bool IsTrueBrackets(string inp)
        {
            inp = new string(inp.Where(t => (t == '(' || t == ')' || t == '{' || t == '}' ||
                                             t == '<' || t == '>' || t == '[' || t == ']')).ToArray());

            while (inp.Contains("()") || inp.Contains("{}") || inp.Contains("<>") || inp.Contains("[]"))
            {
                inp = inp.Replace("()", "").Replace("{}", "").Replace("<>", "").Replace("[]", "");
            }
            return inp.Length == 0;
        }

        private static void FloatingPointInParentheses(string inp)
        {
            //string pattern = @"([(]{1}[-+]{0,1}[0-9]{0,}\.{0,1}[0-9]{0,}[)]{1})|([<]{1}[-+]{0,1}[0-9]{0,}\.{0,1}[0-9]{0,}[>]{1})|([[]{1}[-+]{0,1}[0-9]{0,}\.{0,1}[0-9]{0,}[\]]{1})|([{]{1}[-+]{0,1}[0-9]{0,}\.{0,1}[0-9]{0,}[}]{1})";
            string pattern = @"[(]{1}[-+]{0,1}[0-9]{0,}[.]{0,1}[0-9]{0,}[eE]{0,1}[+-]{0,1}[0-9]{1,}[)]{1}";
            string pattern1 = @"(edvin).{0,}(hakob)";

            MatchCollection m = Regex.Matches(inp, pattern1);
            foreach (var item in m)
                //Console.WriteLine(item.ToString().Substring(1, item.ToString().Length - 2));
            Console.WriteLine(item.ToString());

        }



    }
}
