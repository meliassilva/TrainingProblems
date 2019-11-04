using FSharpVSPowerTools;
using NPoco.Expressions;
using Segment.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanToInt
{
    class Program
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict.Add('I', 1);
            dict.Add('V', 5);
            dict.Add('X', 10);
            dict.Add('L', 50);
            dict.Add('C', 100);
            dict.Add('D', 500);
            dict.Add('M', 1000);

            int num = 0;

            if (s.Contains("IV"))
            {
                s = s.Replace("IV", "");
                num += 4;
            }

            if (s.Contains("IX"))
            {
                s = s.Replace("IX", "");
                num += 9;
            }

            if (s.Contains("XL"))
            {
                s = s.Replace("XL", "");
                num += 40;
            }
            if (s.Contains("XC"))
            {
                s = s.Replace("XC", "");
                num += 90;
            }

            if (s.Contains("CD"))
            {
                s = s.Replace("CD", "");
                num += 400;
            }

            if (s.Contains("CM"))
            {
                s = s.Replace("CM", "");
                num += 900;
            }

            foreach (char c in s)
            {
                num += dict[c];
            }

            return num;


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
