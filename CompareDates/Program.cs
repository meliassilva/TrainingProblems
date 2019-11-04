using System;

namespace CompareDates
{
    class Program
    {
        static int Main(string[] args)
        {
            DateTime sd = new DateTime(2010, 10, 12);
            Console.WriteLine("Starting Date : {0}", sd);
            DateTime ed = sd.AddDays(10);
            Console.WriteLine("Ending Date   : {0}", ed);
            if (sd < ed)
                Console.WriteLine("{0} Occurs Before {1}", sd, ed);
            Console.Read();
            return 0;
        }
    }
}
