using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_prob.Array.Easy
{
    internal class LargeElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
            int large = findLargeElement(arr,n);
            Console.WriteLine($"{large} is the largest element in the given array.");
        }
        static int findLargeElement(int[] arr, int n)
        {
            int large = int.MinValue;
            for (int i = 0;i < n; i++)
            {
                if (arr[i] > large) 
                    large = arr[i];
            }
            return large;
        }
    }
}
