/*
 * C# Program to Illustrate Array of Delegates
 */
using System;
delegate double Measure(double R);

namespace ArrayDelegates
{
    public class Circle
    {
        const double PI = 3.14159;
        public double Diameter(double Radius)
        {
            return Radius * 2;
        }

        public double Circumference(double Radius)
        {
            return Diameter(Radius) * PI;
        }

        public double Area(double Radius)
        {
            return Radius * Radius * PI;
        }
    }
    public static class Program
    {
        static int Main()
        {
            double R = 10;
            Circle circ = new Circle();
            Measure[] Calc = new Measure[3];
            Calc[0] = new Measure(circ.Diameter);
            double D = Calc[0](R);
            Calc[1] = new Measure(circ.Circumference);
            double C = Calc[1](R);
            Calc[2] = new Measure(circ.Area);
            double A = Calc[2](R);
            Console.WriteLine("Diameter:      {0}", D);
            Console.WriteLine("Circumference: {0}", C);
            Console.WriteLine("Area:          {0}\n", A);
            Console.ReadLine();

            return 0;
        }
    }
}
