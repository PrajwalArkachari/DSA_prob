//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Algorithms
//{
//    internal class selectionSort
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int[] arr = new int[n];
//            for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
//            SelectionSort(arr, n);
//            for (int i = 0; i < n; i++)  Console.Write(arr[i]+" ");
//        }
//        static void SelectionSort(int[] arr, int n)
//        {
//                for(int i = 0; i < n-1; i++)
//            {
//                int min = i;
//                for(int j = i+1; j < n; j++)
//                {
//                    if (arr[min] >arr[j])
//                        min = j;
//                }
//                //swap
//                int temp = arr[i];
//                arr[i] = arr[min];
//                arr[min] = temp;

//            }
//        }
//    }
//}
