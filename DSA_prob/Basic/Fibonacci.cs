//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Basic
//{
//    internal class Fibonacci
//    {
//        public static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            findFibonocci(n);
//        }
//        static void findFibonocci(int n)
//        {
//            int first = 0, second=1;
//            int next;
//            if (n >=3)
//            {
//                Console.Write(first + " " + second);
//                for (int i = 3; i <= n; i++)
//                {
//                    next= first+second;
//                    Console.Write(" "+next);
//                    first= second;
//                    second= next;
//                }
//            }
//        }
//    }
//}
