//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Array.Easy
//{
//    internal class removeDuplicates
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int [] arr = new int[n];    
//            for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
//           int num= RemoveDuplicates(arr);
//            for (int i = 0; i < num; i++)
//            {
//                Console.Write(arr[i] + " ");
//            }
//        }


//        //brute force approach
//        //static void RemoveDuplicates(int[] arr)
//        //{
//        //    List<int> list = new List<int>();
//        //    for (int i = 0; i < arr.Length; i++)
//        //    {
//        //        if (!list.Contains(arr[i]))
//        //        {
//        //            list.Add(arr[i]);
//        //        }
//        //    }
//        //    for (int i = 0; i < list.Count; i++)
//        //    {
//        //        Console.Write(list[i] + " ");
//        //    }
//        //}


//          Optimal solutions

//        static int RemoveDuplicates(int [] arr)
//        {
//            int j = 0;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[j] != arr[i])
//                {
//                    j++;
//                    int temp = arr[j];
//                    arr[j] = arr[i];
//                    arr[i] = temp;
//                }
//            }
//            return j + 1;
//        }

//    }
//}
