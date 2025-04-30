using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_prob.Array.Easy
{
    internal class moveZeroToEnd
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++) arr[i]= int.Parse(Console.ReadLine());
            zeroToEnd(arr);
            for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
        }

        //brute force approach
        //static void zeroToEnd(int[] arr)
        //{
        //    int[] ints = new int[arr.Length];
        //    int j = 0;
        //    for(int i = 0;i<arr.Length;i++)
        //    {
        //        if(arr[i] != 0) 
        //        { 
        //            ints[j] = arr[i];
        //            j++;

        //        }
        //    }
        //    for(int i = 0;i < ints.Length;i++) Console.Write(ints[i]+" ");
        //}


        // optimal approach to solve the problems

        static int[] zeroToEnd(int[] arr)
        {
            int j = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    j = i;
                    break;
                }
            }
            if(j==-1) return arr;

            for(int i=j+1;i<arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j++;
                }
            }
            return arr;
        }
    }
}
