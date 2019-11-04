using System;
using System.Collections.Generic;
public class Exercise28
{
    public static void Main()
    {
        string line = "Display the pattern like pyramid using the alphabet.";
        Console.WriteLine("\nOriginal String: " + line);
        string result = "";
        List<string> wordsList = new List<string>();
        string[] words = line.Split(new[] {
   " "
  }, StringSplitOptions.None);
        for (int i = words.Length - 1; i >= 0; i--)
        {
            result += words[i] + " ";
        }
        wordsList.Add(result);
        foreach (String s in wordsList)
        {

            Console.WriteLine("\nReverse String: " + s);
        }
    }
}
