//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace DSA_prob.Algorithms
//{
//    internal class bubbleSort
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int[] arr = new int[n];
//            for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
//            BubbleSort(arr, n);
//            for (int i = 0; i < n; i++) Console.Write(arr[i] + " ");
//        }
//        static void BubbleSort(int[] arr, int n)
//        {
//            bool sorted = true;
//            for(int i=n-1;i>=0;i--)
//            {
//                for(int j = 0; j <= i - 1; j++)
//                {
//                    if (arr[j] > arr[j + 1])
//                    {
//                        sorted = false;
//                        int temp=arr[j];
//                        arr[j]=arr[j + 1];
//                        arr[j+1]=temp;
//                    }
//                }
//                if (sorted) break;
//            }
//        }
//    }
//}


//Time Complexity: O(N2) for the worst and average cases and O(N) for the best case.Here, N = size of the array.
//Space Complexity: O(1)