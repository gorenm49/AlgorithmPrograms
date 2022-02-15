using System;

namespace AlgorithmPrograms
{
    public class BubbleSort
    {
        public void Bubble()
        {

            int[] InputArray = { 97, 55, 45, 88, 21 };
            int temp;
            
            for (int j = 0; j <= InputArray.Length - 2; j++)
            {
                for (int i = 0; i <= InputArray.Length - 2; i++) 
                {
                    if (InputArray[i] > InputArray[i + 1]) 
                    {
                        temp= InputArray[i + 1];
                        InputArray[i + 1] = InputArray[i];
                        InputArray[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted Array is:");
            
            foreach (int data in InputArray)
            {
                Console.Write(data + " ");
            }
            
        }
    }
}