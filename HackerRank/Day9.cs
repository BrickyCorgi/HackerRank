using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Day9
    {
        private Day9() { }

        public static void Recursion()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = Factorial(n);

            Console.WriteLine(result);
        }
        private static int Factorial(int n)
        {
            if (n <= 2)
                return n;
            else
                return n * Factorial(n - 1);
        }
    }
}
