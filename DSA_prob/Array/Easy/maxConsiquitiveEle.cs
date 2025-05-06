using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_prob.Array.Easy
{
    internal class maxConsiquitiveEle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
            int max = FindMaxConsecutiveOnes(arr);
            Console.WriteLine("Maximum element is "+max);
        }
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                    max = Math.Max(max, count);
                }
                if (nums[i] == 0) count = 0;

            }
            return max;
        }
    }

}
