//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Basic
//{
//    internal class checkPalindrome
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            if (CheckPalindrome(n))
//            {
//                Console.WriteLine(n + " is Palindrome");
//            }
//            else { Console.WriteLine(n + " is not a Palindrome");
//            }

//        }
//        static bool CheckPalindrome(int n) {
//            int dup = n;
//            int rev = 0;
//            while (dup > 0)
//            {
//                int rem = dup % 10;
//                rev = rev * 10 + rem;
//                dup = dup / 10;
//            }
//            if(n==rev) return true; else return false;
//        }
//    }
//}


//// Time complexity :--- O(n)
//// space complexity:--- O(1)