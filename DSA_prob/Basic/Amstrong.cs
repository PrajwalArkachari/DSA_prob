//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Basic
//{
//    internal class Amstrong
//    {
//        static void Main(string[] args)
//        {
//            int num = int.Parse(Console.ReadLine());
//            if(isAmstrong(num))
//            Console.WriteLine("Number is Amstrong....!");
//            else
//            {
//                Console.WriteLine("Number is not Amstrong");
//            }
//        }
//        static bool isAmstrong(int num)
//        {
//            int bit = 0;
//            int n = num;
//            int result=0;
//            while (num > 0)
//            {
//                bit++;
//                num /= 10;
//            }
//            num = n;
//            while (n > 0)
//            {
//                int rem = n % 10;
//                result += (int)Math.Pow(rem, bit); 
//                n /= 10;
//            }
//            if (result == num)
//            {
//                return true;
//            }
//            return false;
//        }
//    }
//}
