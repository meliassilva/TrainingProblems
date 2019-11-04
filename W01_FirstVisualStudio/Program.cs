using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace W01_FirstVisualStudio

{
    /// <summary>
    /// 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //declare the variables with value associate
            string name = "Mario";
            string location = " Brazil";

            //display everything
            Console.WriteLine("My name is " + name + ".");
            Console.WriteLine("I'm from" + location + ".");


            //grab the date today
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            ////establish DateTimes
            //DateTime start = new DateTime(2010, 6, 14);
            //DateTime end = new DateTime(2016, 08, 14);

            //TimeSpan difference = end - start; //create TimeSpan object

            //Console.WriteLine("Difference in days: " + difference.Days); //Extract days, write to Console.


            //new variable for the Chrystimas day
            DateTime futurDate = Convert.ToDateTime("12/25/2019");

            //make the calculation and display the result
            var numberOfDays = (futurDate - now);
            Console.WriteLine("The number of the days until Chrystimas is: " + numberOfDays + ".");

            //Call the example method from the book
            GrazerCalc();

            Console.WriteLine("\n Press any key to close the program");
            Console.ReadKey();
        }
        /// <summary>
        /// Method used to calculate lenght and the area
        /// </summary>
        public static void GrazerCalc()
        {
            //variables
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            //input one
            Console.Write("\n Give the width of the window : ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            //input two
            Console.Write("\n Give the height of the window : ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            //calculation
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            //display
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
        }
    }
}


