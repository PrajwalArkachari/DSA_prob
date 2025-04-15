//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Basic
//{
//    internal class gcd
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter two numbers to find the gcd.");
//            int n1=int.Parse(Console.ReadLine());
//            int n2=int.Parse(Console.ReadLine());
//            Console.WriteLine(findGcd(n1, n2)); 
//        }
//        static int findGcd(int n1, int n2)
//        {
//            while (n1 > 0 && n2 > 0)
//            {
//                if (n1 > n2) n1 = n1 % n2;
//                else n2 = n2 % n1;
//            }
//            if(n1==0) return n2;
//            else
//            {
//                return n1;
//            }
//        }
//    }
//}
