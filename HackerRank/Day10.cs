using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Day10
    {
        private Day10() { }

        public static void Binary()
        {
            int n = Convert.ToInt32(Console.ReadLine()),
                rem,
                maxCount = 0,
                count = 0;

            //bitwise operation
            //equivalent of a bit shift right -- okay since only positive n
            while (n > 0)
            {
                rem = n % 2;    //rightmost binary value
                n = n / 2;      //new n value
                if (rem == 1)
                {
                    count++;    //consecutive
                    if (count > maxCount)
                        maxCount = count;
                }
                else            //a 0 broke up string of 1s
                    count = 0;  //reset consecutive counter
            }
            Console.WriteLine(maxCount);
        }
    }
}
