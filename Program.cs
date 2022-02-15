using System;

namespace AlgorithmPrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BinarySearch b = new BinarySearch();         

            System.Console.WriteLine("Enter string value to search:");
            string userInput = Console.ReadLine();

            System.Console.WriteLine("User input is :"+userInput);
            b.BinarySearchIterative(userInput);


        }
    }
}