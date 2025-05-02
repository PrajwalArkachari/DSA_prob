//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Algorithms
//{
//    internal class mergeSortAlgorithm
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int[] arr = new int[n];
//            for (int i = 0; i < n; i++) arr[i]=int.Parse(Console.ReadLine());
//            mergeSort(arr, 0, n - 1);
//            Console.WriteLine("After sorting");
//            for (int i = 0; i < n; i++) Console.Write(arr[i]+" ");
//        }
//        static void mergeSort(int[] arr, int low, int high)
//        {
//            if(low>=high) return;   
//            int mid = (low + high)/2;
//            mergeSort(arr, low, mid);
//            mergeSort(arr,mid+1, high);
//            merge(arr,low,mid,high);
//        }
//        static void merge(int[] arr,int low, int mid, int high)
//        {
//            List<int> list = new List<int>();
//            int left =low;
//            int right =mid+1;

//            while(left<=mid && right<=high)
//            {
//                if (arr[left] <= arr[right])
//                {
//                    list.Add(arr[left]);
//                    left++;
//                }
//                else
//                {
//                    list.Add(arr[right]);
//                    right++;
//                }
//            }
//            while (left <= mid)
//            {
//                list.Add(arr[left]);
//                left++;
//            }

//            //  if elements on the right half are still left //
//            while (right <= high)
//            {
//                list.Add(arr[right]);
//                right++;
//            }
//            for (int i = low; i <= high; i++)
//            {
//                arr[i] = list[i - low];
//            }
//        }
//    }
//}
