using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
	class Day1
	{
		private Day1() { }

		public static void DataTypes()
		{
			int i = 4;
			double d = 4.0;
			string s = "HackerRank ";

			// Declare second integer, double, and String variables.
			int num;
			double dec;
			String txt;

			//Get input values from user
			Console.WriteLine("Provide an appropriate value as prompted...\n");
			// Read and save an integer, double, and String to your variables.
			Console.Write("Enter a whole number: ");
			num = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter a decimal number: ");
			dec = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter a line of text: ");
			txt = Console.ReadLine();

			Console.WriteLine();
			// Print the sum of both integer variables on a new line.
			Console.WriteLine(i + num);

			// Print the sum of the double variables on a new line.
			Console.WriteLine(String.Format("{0:0.0}", (d + dec)));

			// Concatenate and print the String variables on a new line
			Console.WriteLine(s + txt);
			// The 's' variable above should be printed first.
		}
	}
}
