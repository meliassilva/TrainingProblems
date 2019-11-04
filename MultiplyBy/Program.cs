using System;

namespace MultiplyBy
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, tempnum;
            Console.WriteLine("Enter an integer :");
            number = int.Parse(Console.ReadLine());
            tempnum = number;
            number = number << 2;
            Console.WriteLine("{0},{1}", tempnum, number);
            Console.ReadLine();
        }
    }
}
