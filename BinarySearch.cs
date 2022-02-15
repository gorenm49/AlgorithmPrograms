using System;

namespace AlgorithmPrograms
{
    public class BinarySearch
    {
        
        public void BinarySearchIterative(string userInput)  
        { 
            string[]  strInputArray = {"abc", "mbbs", "life", "notwell","whynot"};
            int min = 0, mid =0, result =-1;
            int max = strInputArray.Length - 1; 

            System.Console.WriteLine("Array values are:");
            for (int i = 0; i <= max; i++)
            {
                System.Console.WriteLine(strInputArray[i]);
            }
            System.Console.WriteLine("\n");

            while (min <= max)
            {
                mid = min+(min-1)/2;

                if(userInput.Equals(strInputArray[mid]))
                {
                    result =0;
                }
                
                if (result == 0)
                {
                    System.Console.WriteLine("match found");
                }

                int val = Convert.ToInt32(userInput.CompareTo(strInputArray[mid]));

                if (val == 1)
                {
                    min = mid+1;
                    result = 1;
                }
                else
                {
                    max = mid-1;
                    result = 1;
                }
            }

            if (result == -1)
            {
                System.Console.WriteLine("String not found");
            }
            else if(result == 1)
            {
                System.Console.WriteLine("String found");
            }

           

            // for (int i = 0; i <= mid; i++)
            // {
            //     if (strInputArray[i].Equals(userInput))
            //     {
            //         System.Console.WriteLine("String found!!");
            //     }
                
            // } 
        } 
    }
    
}