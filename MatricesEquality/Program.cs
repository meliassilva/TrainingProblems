/*
 * C# Program to Check the Equality of Matrices
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication8
{
    class Program
    {
        int x;
        public static void Main(string[] args)
        {
            int m, n, i, j;
            Console.Write("Enter Number Of Rows And Columns Of Matrices A and B : ");
            m = Convert.ToInt16(Console.ReadLine());
            n = Convert.ToInt16(Console.ReadLine());
            int[,] A = new int[10, 10];
            Console.Write("\nEnter The First Matrix : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    A[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            int[,] B = new int[10, 10];
            Console.Write("\nEnter The Second Matrix:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    B[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("\nMatrix A : ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("\nMatrix B: ");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(B[i, j] + "\t");

                }
                Console.WriteLine();
            }
            int[,] C = new int[10, 10];
            bool flag = true;
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (A[i, j] == B[i, j])
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("Matrices are Equal  ");
            }
            else
            {
                Console.WriteLine("Not Equal ");
            }
            Console.Read();
        }
    }
}
