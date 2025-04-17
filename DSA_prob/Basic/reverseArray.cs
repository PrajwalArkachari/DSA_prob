//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Basic
//{
//    internal class reverseArray
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int[] arr = new int[n];
//            for (int i = 0; i < n; i++)
//            {
//                arr[i] = int.Parse(Console.ReadLine());
//            }
//            revArray(arr);
//           foreach (int i in arr)
//            {
//                Console.WriteLine(i);
//            }
//        }
//        static void revArray(int[] arr)
//        {
//            Console.WriteLine("Post sorting");
//            int left=0, right=arr.Length-1;
//            while (left < right)
//            {
//                int temp = arr[left];
//                arr[left] = arr[right];
//                arr[right] = temp;
//                left++;
//                right--;
//            }
//        }
//    }
//}
