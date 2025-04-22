//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Basic
//{
//    class NumHashing
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the array size");
//            int n = int.Parse(Console.ReadLine());
//            int[] arr = new int[n];
//            for(int i=0;i<n;i++)
//            {
//                arr[i] = int.Parse(Console.ReadLine());
//            }
//            int[] hash = new int[12];
//            foreach (int i in arr)
//            {
//                hash[arr[i]] += 1;
//            }
//            Console.WriteLine("Enter the number of queries");
//            int q = int.Parse(Console.ReadLine());
//            while(q-->0)
//            {
//                Console.WriteLine("Enter the number to fetch data for query");
//                int num = int.Parse(Console.ReadLine());
//                Console.WriteLine(hash[num]);
//            }
//        }
//    }
//}
