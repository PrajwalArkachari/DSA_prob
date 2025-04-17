using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_prob.Basic
{
    internal class sum1stNnum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(sumOfN(n));
        }
        
        static int sumOfN(int n)
        {
            int sum = 0;
            for (int i=0;i<=n;i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
