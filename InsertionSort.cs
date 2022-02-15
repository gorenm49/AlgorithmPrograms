using System;

namespace AlgorithmPrograms
{
    public class InsertionSort
    {
        public void InsertionSortMethod()
        {
            string[] strArray = { "Two", "Nine", "Five", "Eight" ,"One"};

            System.Console.WriteLine("Before sort Array is:");
            foreach (var item in strArray)
            {
                Console.WriteLine(item);
            }

            for (int i = 1; i < strArray.Length; i++)
            {
                string value = strArray[i];
                int j = i - 1;
                while ((j >= 0) && (strArray[j].CompareTo(value) > 0))
                {
                    strArray[j + 1] = strArray[j];
                    j--;
                }
                strArray[j + 1] = value;
            }

            System.Console.WriteLine("Afer Sort Array is:");
            foreach (var item in strArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}