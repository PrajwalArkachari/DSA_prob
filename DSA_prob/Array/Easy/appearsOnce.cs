//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Array.Easy
//{
//    internal class appearsOnce
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int[] arr = new int[n];
//            for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
//            int number=SingleNumber(arr);
//            Console.WriteLine("Number appears only onces in the given array is "+number);

//        }
//        public static int SingleNumber(int[] nums)
//        {
//            int xor = 0;
//            for (int i = 0; i < nums.Length; i++)
//            {
//                xor = xor ^ nums[i];
//            }
//            return xor;
//        }
//    }
//}
