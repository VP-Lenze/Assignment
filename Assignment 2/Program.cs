using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-----------------Assignment 2-----------------\n\n");

            string outputFile = @"Assignment 2_output.txt";

            try
            {
                Console.Write("Enter size of array : ");
                int size = Convert.ToInt32(Console.ReadLine());
                if (size >= 1)
                {
                    string[] stringArray = new string[size];
                    for (int i = 0; i < size; i++)
                    {
                        stringArray[i] = Console.ReadLine();
                    }
                    File.WriteAllLines(outputFile, stringArray);
                    string[] fileLines = File.ReadAllLines(outputFile);
                    int pairs = 0;
                    Console.WriteLine($"Input array : {string.Join(",", fileLines)}");
                    Console.Write("Input number to find pairs : ");
                    int key = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < fileLines.Length; i++)
                    {
                        if (fileLines[i] == key.ToString())
                        {
                            pairs++;
                        }
                    }
                    Console.WriteLine($"Total pairs : {Math.Floor((double) pairs / 2)}\n");
                }
                else
                {
                    Console.WriteLine("Minimum length of array should be 30\n");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
