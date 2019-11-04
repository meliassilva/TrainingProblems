using System;

namespace TrigonometryAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trignometric Values in Radians : ");
            Console.WriteLine("sin (pi/3)    = {0}", Math.Sin(Math.PI / 3));
            Console.WriteLine("cos (pi/3)    = {0}", Math.Cos(Math.PI / 3));
            Console.WriteLine("tan (pi/3)    = {0}", Math.Tan(Math.PI / 3));
            Console.WriteLine("arcsin (1/2)  = {0}", Math.Asin(0.5));
            Console.WriteLine("arccos (1/2)  = {0}", Math.Acos(0.5));
            Console.WriteLine("arctan (1/2)  = {0}", Math.Atan(0.5));
            Console.ReadLine();
        }
    }
}
