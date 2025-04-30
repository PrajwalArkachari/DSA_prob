//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Array.Easy
//{
//    internal class union
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int m = int.Parse(Console.ReadLine());

//            int[] arr1 = new int[n];
//            int[] arr2 = new int[m];
//            Console.WriteLine("Enter the values for 1st array");
//            for (int i = 0; i < n; i++) {
//                arr1[i] = int.Parse(Console.ReadLine());
                                            
//            }
//            Console.WriteLine("Enter the values for 1st array");
//            for(int i = 0;i < m; i++) arr2[i] = int.Parse(Console.ReadLine());
//            List<int> list = doUnion(arr1 , arr2,n,m);
//            foreach (int i in list) Console.Write(i + " ");
//        }

//        //brute force approach
//        //static void doUnion(int[] arr1, int[] arr2)
//        //{
//        //    List<int> list = new List<int>();
//        //    int n = arr1.Length;
//        //    int m = arr2.Length;
//        //    for (int i = 0; i < n; i++)
//        //    {
//        //        if(!list.Contains(arr1[i]))
//        //        list.Add(arr1[i]);
//        //    }
//        //    for(int i = 0;i<m;i++)
//        //    {
//        //        if(!list.Contains(arr2[i]))
//        //        list.Add(arr2[i]);
//        //    }
//        //    Console.WriteLine();

//        //    foreach (var item in list)
//        //    {
//        //        Console.Write(item + " ");
//        //    }
//        //}


//        // optimal approach 
//        static List<int> doUnion(int[] arr1, int[] arr2, int n, int m)
//        {
//            int i=0, j=0;
//            List<int> list = new List<int>();
//            while(i<n && j<m)
//            {
//                if (arr1[i]<=arr2[j])
//                {
//                    list.Add(arr1[i]);
//                    i++;
//                }
//                else if (list.Contains(arr2[j])) j++;
//            }
//            while (i < n)
//            {
//                if(!list.Contains(arr1[i]))
//                {
//                    list.Add(arr1[i]);
                    
//                }
//                i++;
//            }
//            while (j < m)
//            {
//                if(!list.Contains(arr2 [j]))
//                {
//                    list.Add(arr2 [j]);
//                }
//                j++;
//            }
//            return list;
//        }
       
//    }
//}
