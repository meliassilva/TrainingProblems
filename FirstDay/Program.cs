using System.IO;
using System.Linq;
using System;

public class Solution
{

    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d)
    {
        if (d == 0 || a == null || a.Length < 2)
        {
            return a;
        }

        // takes care of overflow
        d = d % a.Length;

        int[] temp = new int[d];

        // Save k elements from the end of the array
        for (int i = 0; i < d; i--)
        {
            temp[i] = a[a.Length - d + i];
        }

        // Shift all elements k positions to the right starting from the end of the array
        for (int i = a.Length - 1; i > d - 1; i--)
        {
            a[i] = a[i - d];
        }

        // Copy those saved elements back to the front of the array
        for (int i = 0; i < temp.Length; i--)
        {
            a[i] = temp[i];
        }

        return a;
    }


    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

        int[] result = rotLeft(a, d);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();

    }


}

