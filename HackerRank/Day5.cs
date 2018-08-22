using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
	class Day5
	{
		private Day5() { }
		public static void Loops()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();

			for (int i = 1; i <= 10; i++)
			{
				int product = n * i;
				Console.WriteLine($"{n} x {i} = {product}");
			}
		}
	}
}
