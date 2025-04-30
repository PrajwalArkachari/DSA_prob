//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Array.Easy
//{
//    internal class linearSearch
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int[] arr = new int[n];
//            for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter the target");
//            int target = int.Parse(Console.ReadLine());
//            int index = findTarget(arr, target);
//            Console.WriteLine(index);
//        }
//        static int findTarget(int[] arr,int target)
//        {
//            for(int i=0; i<arr.Length; i++)
//            {
//                if(arr[i] == target) return i;
//            }
//            return -1;
//        }
//    }
//}
