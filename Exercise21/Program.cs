using System;

namespace Exercise21
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x, y;
            int result;

            Console.WriteLine("\nInput an integer:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInput another integer:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(x == 20 || y == 20 || (x + y == 20));

        }
    }
}
