//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Array.Easy
//{
//    internal class missingNumber
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int[] arr = new int[n];
//            for(int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
//            int missing = MissingNumber(arr);
//            Console.WriteLine(missing);
//        }
//        static int MissingNumber(int[] nums)
//        {
//            int n = nums.Length;
//            int sum = (n * (n + 1)) / 2;
//            int j = 0;
//            for (int i = 0; i < n; i++) j += nums[i];
//            int missingNum = sum - j;
//            return missingNum;
//        }
//    }
//}
