using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-----------------Assignment 1-----------------\n\n");

            string file = @"Assignment 1.txt";
            if (File.Exists(file))
            {
                String[] lines = File.ReadAllLines(file);
                Console.Write("Enter word to search : ");
                String key = Console.ReadLine();
                int totalOccurrance = 0, index = 0;
                for (int i = 0; i < lines.Length; i++)
                {
                    MatchCollection mc = Regex.Matches(lines[i], String.Format(@"\b(?i){0}\b", key));
                    int length = mc.Count;
                    if (length > 0)
                    {
                        totalOccurrance += length;
                    }
                    if (index == 0 && totalOccurrance > 1)
                    {
                        index = i + 1;
                    }
                }
                Console.WriteLine($"Total Occurrance : {totalOccurrance}\n");
                if (index > 0)
                {
                    Console.WriteLine($"Answer : Line {index}\n");
                }
            }
        }
    }
}
