//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DSA_prob.Basic
//{
//    internal class AllDivisor
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            List<int> arrayList = new List<int>();
//            arrayList = findDivisor(n);
//            foreach (int i in arrayList)
//            {
//                Console.Write(i+" ");
//            }
//        }

//        static List<int> findDivisor(int n)
//        {
//            List<int> _list = new List<int>();
//            for(int i = 1; i <=Math.Sqrt(n); i++)
//            {
//                if(n%i == 0)
//                {
//                    _list.Add(i);
//                }
//            }
//            return _list;
//        }
//    }
//}
