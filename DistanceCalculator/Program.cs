/*
 * C# Program to Calculate the Distance Travelled by Reading Speed and Time
 */
using System;
class program
{
    public static void Main()
    {
        int speed, distance, time;
        Console.WriteLine("Enter the Speed(km/hr) : ");
        speed = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Time(hrs) : ");
        time = Convert.ToInt32(Console.ReadLine());
        distance = speed * time;
        Console.WriteLine("Distance Travelled (kms) : " + distance);
        Console.ReadLine();
    }
}
