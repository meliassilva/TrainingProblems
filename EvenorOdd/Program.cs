using System;

namespace EvenorOdd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter a number: ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Entered Number is an Odd Number");
                Console.Read();
            }


        }
    }
}
