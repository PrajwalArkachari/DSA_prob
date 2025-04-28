//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Array.Easy
//{
//    internal class sortedRotated
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int[] arr = new int[n];
//            for (int i = 0; i < n; i++) arr[i]=int.Parse(Console.ReadLine());
//            if (isSortedOrRotated(arr)) Console.WriteLine("True");
//            else Console.WriteLine("False");
//        }
//        static bool isSortedOrRotated(int[] arr)
//        {
//            int x = 1;
//            int count = 0;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                int pivot = arr[(i + x) % arr.Length];
//                if (arr[i] > pivot)
//                {
//                    count++;
//                    if(count>1) return false;
//                }
//            }
//            return true;
//        }
//    }
//}
