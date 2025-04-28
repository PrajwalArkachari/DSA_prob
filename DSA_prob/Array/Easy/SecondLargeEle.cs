//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Array.Easy
//{
//    internal class SecondLargeEle
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int[] arr = new int[n];
//            for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
//            findSecondLargeEle(arr,n);
//            findSecondSmallEle(arr,n);
//        }

//        // brute force approach
//        //static void findSecondLargeEle(int[] arr, int n)
//        //{
//        //    int firstMax = int.MinValue;
//        //    int secondMax = int.MinValue;
//        //    for (int i = 0;i < n;i++)
//        //    {
//        //        if(arr[i] > firstMax) firstMax = arr[i];
//        //    }
//        //    for (int i = 0;i < n;i++)
//        //    {
//        //        if (arr[i]>secondMax && arr[i]<firstMax) secondMax = arr[i];
//        //    }
//        //    Console.WriteLine("First largest element is " + firstMax);
//        //    Console.WriteLine("Second largest element is "+ secondMax);
//        //}
        
//        //optimal solution
//        static void findSecondLargeEle(int[] arr, int n)
//        {
//            int firstMax = int.MinValue;
//            int secondMax = -1;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] > firstMax)
//                {
//                    secondMax = firstMax;
//                    firstMax = arr[i];
//                }
//                else if (arr[i]>secondMax && arr[i]!=firstMax) secondMax = arr[i];
//            }
//            Console.WriteLine("First largest element is " + firstMax);
//            Console.WriteLine("Second largest element is "+ secondMax);
//        }
//        static void findSecondSmallEle(int[] arr, int n)
//        {
//            int firstSmall = int.MaxValue;
//            int secondSmall = -1;
//            for(int i = 0;i < n;i++)
//            {
//                if (arr[i] < firstSmall)
//                {
//                    secondSmall = firstSmall;
//                    firstSmall = arr[i];
//                }
//                else if (secondSmall > arr[i] && arr[i] != firstSmall)
//                {
//                    secondSmall = arr[i];
//                }
//            }
//            Console.WriteLine("First smallest element is "+firstSmall);
//            Console.WriteLine("Second smallest element is "+secondSmall);
//        }
//    }
//}
