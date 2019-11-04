using System;

namespace SwapAgain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.WriteLine("\n Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
            Console.Read();

        }
    }
}
