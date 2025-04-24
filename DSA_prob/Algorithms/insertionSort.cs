//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Algorithms
//{
//    internal class insertionSort
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int[] arr = new int[n];
//            for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
//            Insertionsrt(arr, n);
//            for (int i = 0; i < n; i++) Console.Write(arr[i] + " ");
//        }
//        static void Insertionsrt(int[] arr, int n)
//        {
//            for (int i = 0; i<n;i++) 
//            {
//                int j = i;
//                while (j > 0 && arr[j - 1] > arr[j])
//                {
//                    int temp = arr[j - 1];
//                    arr[j - 1] = arr[j];
//                    arr[j]= temp;
//                    j--;
//                }
//            }
//        }
//    }
//}


//Time complexity: O(N2), (where N = size of the array), for the worst, and average cases.
//Reason: If we carefully observe, we can notice that the outer loop, say i, is running from 0 to n-1 i.e. n times, and for each i, the inner loop j runs from i to 1 i.e. i times.
//For, i = 1, the inner loop runs 1 time, for i = 2, the inner loop runs 2 times, and so on. So, the total steps will be approximately the following: 1 + 2 + 3 + ......+(n - 2) + (n - 1).
//The summation is approximately the sum of the first n natural numbers i.e. (n*(n+1))/2. The precise time complexity will be O(n2/2 + n/2).
//Previously, we have learned that we can ignore the lower values as well as the constant coefficients. So, the time complexity is O(n2). Here the value of n is N i.e. the size of the array.

//Space Complexity: O(1)