using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Day11
    {
        private Day11() {}

        public static void TwoDArray() {
            const int arrSize = 6;
            int[][] arr = new int[arrSize][];
            int sum = 0,                    //sum of current hourglass
                maxSum = Int32.MinValue,    //largest hourglass sum, starts off as a large negative number
                row = 0, 
                col = 0;

            //Build 2-d array from user input
            
            for (int i = 0; i < arrSize; i++)
            { 
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => 
                    Convert.ToInt32(arrTemp));
            }
            
            /*
            string path = @"G:\My Drive\CodingPractice\HackerRank\2-d Array of Hourglass Sums\2d-array-testcases\input\input00.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    for (int i = 0; i < 6; i++)
                    {
                        arr[i] = Array.ConvertAll(sr.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            */

            for (row = 0; row < arrSize - 2; row++)
            {

                for (col = 0; col < arrSize - 2; col++)   
                {
                    //hourglass top
                    sum += arr[row][col] + arr[row][col + 1] + arr[row][col + 2];
                    //hourglass center
                    sum += arr[row + 1][col + 1]; 
                    //hourglass bottom
                    sum += arr[row + 2][col] + arr[row + 2][col + 1] + arr[row + 2][col + 2]; 

                    //compare to the current maximum hourglass sum
                    if (sum > maxSum)
                        maxSum = sum;
                    sum = 0;    //reset sum for next hourglass
                }
            }
            Console.WriteLine(maxSum);

        }

    }
}
