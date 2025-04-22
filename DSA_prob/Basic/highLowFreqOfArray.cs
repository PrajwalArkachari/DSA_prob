//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Basic
//{
//    internal class highLowFreqOfArray
//    {
//        static void Main(string[] args)
//        {
//            //Brute force approach

//            //int n = int.Parse(Console.ReadLine());
//            //int[] arr = new int[n];    
//            //int min = int.MaxValue;
//            //int max = int.MinValue;
//            //int maxValue = 0, minValue = 0;
//            //int[] hash = new int[16];
//            //for (int i=0;i<n; i++)
//            //{
//            //    arr[i] = int.Parse(Console.ReadLine());
//            //    hash[arr[i]] +=1;
//            //    if (hash[arr[i]] > max) 
//            //    {
//            //        max = hash[arr[i]]; 
//            //        maxValue = arr[i];
//            //    }
//            //    if (hash[arr[i]] <= min)
//            //    {
//            //        min = hash[arr[i]];
//            //        minValue = arr[i];
//            //    }
//            //}
//            //Console.WriteLine($"Max value {maxValue} and min value {minValue}");


//            //optimal approach using dictionary.....!!!

//            int n = int.Parse(Console.ReadLine());
//            int[] arr = new int[n];    
//            for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
//            findFreq(arr);

//        }
//        static void findFreq(int[] arr)
//        {
//            Dictionary<int, int> map = new Dictionary<int, int>();
//            for (int i = 0;i < arr.Length;i++)
//            {
//                if (map.ContainsKey(arr[i]))
//                {
//                    map[arr[i]]++;
//                }
//                else map[arr[i]]=1;
//            }
//            int count = 1;
//            int maxFreq=int.MinValue, minFreq=int.MaxValue;
//            int maxEle=0, minEle=0;
//            foreach (var value in map)
//            {
//                if(value.Value > maxFreq)
//                {
//                    maxFreq= value.Value;
//                    maxEle = value.Key;
//                }
//                if(value.Value < minFreq)
//                {
//                    minFreq= value.Value;
//                    minEle = value.Key;
//                }
//            }
//            Console.WriteLine($"Max element is {maxEle} with frequency {maxFreq} \n\n Min element is {minEle} with frequency {minFreq}");
//        }
//    }
//}
