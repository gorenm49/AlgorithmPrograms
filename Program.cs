using System;

namespace AlgorithmPrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            
            System.Console.WriteLine("Welcome to Algorithm Programs :  \n Choose operation :"+
            "\n 1. Binary search"+
            "\n 2. Bubble sort"+
            "\n 3. Exit");

            int option = Convert.ToInt32(Console.ReadLine());
            

            switch (option)
            {
                case 1:
                    BinarySearch bs = new BinarySearch();
                    System.Console.WriteLine("Enter string value to search:");
                    string userInput = Console.ReadLine();
                    System.Console.WriteLine("User input is :"+userInput);
                    bs.BinarySearchIterative(userInput);
                    break;
                case 2:
                    BubbleSort bubble = new BubbleSort();
                    bubble.Bubble();    
                    break;
                case 3:
                    break;
                default:
                    System.Console.WriteLine("Choose correct option");
                    break;
            }
        }
    }
}