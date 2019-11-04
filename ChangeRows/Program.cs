using System;

namespace ChangeRows
{
    class intechangerow
    {
        int m, n;
        int[,] a;
        public void interchangerow(int x, int y)
        {
            m = x;
            n = y;
            a = new int[m, n];
        }

        public void readmatrix()
        {
            Console.WriteLine("Enter the Elements : ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("a[{0},{1}]=", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void printmax()
        {
            Console.WriteLine("Given Matrix : ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", a[i, j]);

                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
