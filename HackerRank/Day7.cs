using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Day7
    {
        private Day7() { }
        //get array size
        private static int arrSz = Convert.ToInt32(Console.ReadLine());
        //get that many values from user
        private static int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        public static void Arrays()
        {
            for (int i = arrSz - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }


    }
}
