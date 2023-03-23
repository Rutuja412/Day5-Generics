using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Problems
{
    internal class DeleteElement
    {
        public static void DeleteNumber(int[] arr, int delete)
        {
             int k = 0;
            int[] result = new int[arr.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (delete != arr[i])
                {
                    result[k] = arr[i];
                    k++;
                }
            }
            Console.WriteLine("Modified elements ;");
            foreach (int j in result)
            {
                Console.WriteLine(j + "");
            }

        }
        public static void DeleteElementDubleArray(double[] arr, double delete)
        {
            int k = 0;
            double[] result = new double[arr.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (delete != arr[i])
                {
                    result[k] = arr[i];
                    k++;
                }
            }
            Console.WriteLine("Modified Array: ");
            foreach (double j in result)
            {
                Console.WriteLine(j + "");
            }
        }
        public static void DeleteElementCharArray(char[] arr, char delete)
        {
            int k = 0;
            char[] result = new char[arr.Length - 1];

            for (int i = 0; i < arr.Length; i++)
            {
                if (delete != arr[i])
                {
                    result[k] = arr[i];
                    k++;
                }
            }
            Console.WriteLine("Modified Array: ");
            foreach (char j in result)
            {
                Console.Write(j + " ");
            }

        }
    }
}
