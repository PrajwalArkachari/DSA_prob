//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Basic
//{
//    internal class freqOfArray
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int[] ints = new int[n];
//            for (int i = 0; i < n; i++) { ints[i] = int.Parse(Console.ReadLine()); }
//            int[] hash = new int[16];
//            foreach (int i in ints) { hash[i] += 1; }
//            Console.WriteLine("Enter the number of queries");
//            int queries= int.Parse(Console.ReadLine());
//            while (queries-- > 0)
//            {
//                Console.WriteLine("Enter the query to search frequency");
//                int query = int.Parse(Console.ReadLine());
//                Console.WriteLine($"Frequency of {query} in given array is {hash[query]}");
//            }
//        }
//    }
//}
