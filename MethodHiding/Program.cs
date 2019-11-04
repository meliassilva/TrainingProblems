using System;
using System.Collections.Generic;
using System.Text;

namespace MethodHiding
{


    public class Demo
    {
        public virtual double Area(double r)
        {
            return r * r;
        }

        public void func()
        {
            Console.WriteLine("Base class");
        }
    }
    public class A : Demo
    {
        public override double Area(double r)
        {
            return base.Area(r) * r;
        }
        public new void func()
        {
            Console.WriteLine("Derived Class");
        }
    }
    public class Test
    {
        public static void Main(string[] args)
        {
            A o1 = new A();
            Console.WriteLine(o1.Area(20));
            o1.func();
            Console.ReadLine();
        }
    }



}
