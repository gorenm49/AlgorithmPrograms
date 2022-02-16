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
            "\n 5. Prime Number"+
            "\n 6. Merge Sort"+
            "\n 7. Exit");

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
                    PrimeNumber prime = new PrimeNumber();
                    prime.PrimeLogic();
                    break;
                case 6:
                    MergeSort merge = new MergeSort();
                    int[] arrPass = {78, 99, 12, 65, 100, 76, 89, 23, 1, 55};
                    int len = Convert.ToInt32(arrPass.Length);
                    merge.mergeSort(arrPass,0,len-1);
                    for (int i = 0; i < arrPass.Length; i++) 
                    {
                          Console.Write(arrPass[i] + " ");
                    }
                    break;
                case 7:
                    break;
                default:
                    System.Console.WriteLine("Choose correct option");
                    break;
            }
        }
    }
}
