using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
	class Day2
	{
		private Day2() { }

		
		public static void Operators()
		{
			string fileDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"../../Day2"));
			string[] files = Directory.GetFiles(fileDirectory);

			double meal_cost = 0;
			int tip_percent = 0;
			int tax_percent = 0;

			foreach (string file in files)
			{
				FileStream fileStream = new FileStream(file, FileMode.Open);
				using(StreamReader sr = new StreamReader(fileStream))
				{
					meal_cost = Convert.ToDouble(sr.ReadLine());
					tip_percent = Convert.ToInt32(sr.ReadLine());
					tax_percent = Convert.ToInt32(sr.ReadLine());
				}
				CalcTab(meal_cost, tip_percent, tax_percent);
				Console.WriteLine("\n");
			}
		}

		/// <summary>
		/// Uses the values saved from the input file in Operators() method
		/// to calculate a total cost of meal
		/// </summary>
		/// <param name="meal_cost"></param>
		/// <param name="tip_percent"></param>
		/// <param name="tax_percent"></param>
		private static void CalcTab(double meal_cost, int tip_percent, int tax_percent)
		{
			double total = Math.Round(meal_cost + (meal_cost * (tax_percent/100.0)) + (meal_cost * (tip_percent/100.0))); 

			Console.WriteLine($"The total meal cost is {total} dollars.");
		}

	}
}
