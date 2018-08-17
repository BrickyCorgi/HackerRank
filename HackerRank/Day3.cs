using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
	class Day3
	{
		private Day3() { }
		public static void ConditionalStatements()
		{
			string flag = "Y";		//flag signals whether not user wishes to continue

			while(flag == "Y")
			{
				int n = Convert.ToInt32(Console.ReadLine());
				if (((n % 2) > 0))  //if n is odd
					Console.WriteLine("Weird");
				else  //n is even
				{
					if ((n >= 2 && n <= 5) || (n > 20))
						Console.WriteLine("Not Weird");
					if (n >= 6 && n <= 20)
						Console.WriteLine("Weird");
				}
				Console.Write("Continue? (Y/N): ");
				flag = Console.ReadLine().ToUpper();
			}
			
		}//end ConditionalStatements
	}//end class Day3
}
