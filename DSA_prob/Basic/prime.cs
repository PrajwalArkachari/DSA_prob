//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Basic
//{
//    internal class prime
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            if (isPrime(n))
//            {
//                Console.WriteLine(" The number is Prime.");
//            }
//            else Console.WriteLine("The number is not Prime.");
//        }
//        static bool isPrime(int n)
//        {
//            if(n==1) return false;
//            if(n==2 ||  n==3) return true;

//            for(int i=2;i<n;i++)
//            {
//                if(n%i==0) return false;
//            }
//            return true;
//        }
//    }
//}
