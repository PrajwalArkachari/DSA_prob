//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Basic
//{
//    internal class reverseNumber
//    {
//        static void Main(string[] args)
//        {
//            int num = int.Parse(Console.ReadLine());
//            Console.WriteLine(reverseNum(num));
//        }
//        static int reverseNum(int num)
//        {
//            int rev = 0;
//            while(num > 0)
//            {
//                rev = rev * 10 + num%10;
//                num /= 10;
//            }
//            return rev;
//        }
//    }
//}
