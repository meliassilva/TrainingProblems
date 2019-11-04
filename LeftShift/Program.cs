using System;

namespace LeftShift
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 1024 * 1024 * 1024;
            uint p = 1024 * 1024 * 1024;
            int y = -42;
            Console.WriteLine("LEFT SHIFT OPERATIONS :");
            Console.WriteLine("{0},{1},{2}", x, x * 2, x << 1);
            Console.WriteLine("{0},{1},{2}", p, p * 2, p << 1);
            Console.WriteLine("{0},{1},{2}", x, x * 4, x << 2);
            Console.WriteLine("{0},{1},{2}", p, p * 4, p << 2);
            Console.WriteLine("{0},{1},{2}", y, y * 1024 * 1024 * 64, x << 26);
            Console.ReadLine();

        }
    }
}
