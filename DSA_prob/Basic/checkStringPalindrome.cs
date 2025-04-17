//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Basic
//{
//    internal class checkStringPalindrome
//    {
//        static void Main(string[] args)
//        {
//            string str = Console.ReadLine();
//            if (checkPalindrome(str)) Console.WriteLine("String is Palindrome");
//            else Console.WriteLine("String is not Palindrome");
//        }
//        static bool checkPalindrome(string str)
//        {
//            int left=0, right=str.Length-1;
//            while(left<right)
//            {
//                if (str[left] != str[right])
//                {
//                    return false;
                    
//                }
//                left++; right--;
//            }
//            return true;
//        }
//    }
//}
