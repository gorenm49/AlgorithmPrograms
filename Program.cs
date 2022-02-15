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
            "\n 3. Insertion Sort"+
            "\n 4. Anagram Detection"+
            "\n 5. Exit");

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
                    InsertionSort sort = new InsertionSort();
                    sort.InsertionSortMethod();
                    break;
                case 4:
                    Anagram detect = new Anagram();
                    detect.AnagramDetection();
                    break;
                case 5:
                    break;
                default:
                    System.Console.WriteLine("Choose correct option");
                    break;
            }
        }
    }
}