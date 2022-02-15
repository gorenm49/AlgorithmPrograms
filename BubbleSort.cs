using System;

namespace AlgorithmPrograms
{
    public class BubbleSort
    {
        public void Bubble()
        {

            int[] arr = { 97, 55, 45, 88, 21 };
            int temp;
            
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++) 
                {
                    if (arr[i] > arr[i + 1]) 
                    {
                        temp= arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted Array is:");
            
            foreach (int p in arr)
            {
                Console.Write(p + " ");
            }
            
        }
    }
}