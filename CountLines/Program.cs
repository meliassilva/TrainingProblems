using System;
using System.Text.RegularExpressions;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = countstring("This is \n SanFoundry\n Website");
            Console.WriteLine("Number of Lines in the String : {0}", a);
            Console.ReadLine();
        }

        static long countstring(string s)
        {
            long count = 1;
            int start = 0;
            while ((start = s.IndexOf("\n, start")) != -1)
            {
                count++;
                start++;
            }
            return count;
        }
    }
}
