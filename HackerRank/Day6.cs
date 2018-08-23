using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
	class Day6
	{
		private Day6() { }

		public static void Review()
		{
			int t = Convert.ToInt32(Console.ReadLine());    //# of test cases
			String[] testStr = new String[t];

			for (int i = 0; i < t; i++)
			{
				testStr[i] = Console.ReadLine();
			}	
			for(int s = 0; s < testStr.Length; s++)
			{
				for (int c = 0; c < testStr[s].Length; c = c + 2)
				{
					Console.Write(testStr[s].ElementAt(c));
				}
				Console.Write(" ");
				for (int c = 1; c < testStr[s].Length; c = c + 2)
				{
					Console.Write(testStr[s].ElementAt(c));
				}
				Console.WriteLine();
			}
				

				
			
		}
	}
}
