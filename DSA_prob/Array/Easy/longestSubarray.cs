//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Array.Easy
//{
//    internal class longestSubarray
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int[] arr = new int[n];
//            for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter the K");
//            int k = int.Parse(Console.ReadLine());
//            int res =findLongestSubArray(arr,k,n);
//            Console.WriteLine("Longest length is "+res);
//        }
//        static int findLongestSubArray(int[] arr, int k, int n)
//        {
//            int sum = 0;
//            int maxLen = 0;
//            Dictionary<int, int> map = new Dictionary<int, int>();
//            foreach (int i in arr)
//            {
//                sum += i;
//                if(sum==k) maxLen = Math.Max(maxLen, i);

//                int rem = sum - k;
//                if (map.ContainsKey(rem))
//                {
//                    int len = i-map[rem];
//                    maxLen = Math.Max(maxLen, len);
//                }

//                if(!map.ContainsKey(sum))
//                {
//                    map[sum] = i;
//                }
//            }
//            return maxLen;
//        }
//    }
//}
