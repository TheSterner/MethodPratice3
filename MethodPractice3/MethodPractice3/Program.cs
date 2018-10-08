using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice3
{
	class Program
	{
		static void Main(string[] args)
		{
			var empty = false;

			while (!empty)
			{
				Console.WriteLine("Please enter a number between 1-50");
				int userNum = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Please enter another number between 1-50 or don't.  You don't have to if you don't want to.");
				var userNum2 = Console.ReadLine();
				empty = !string.IsNullOrWhiteSpace(userNum2) && userNum2.All(c => c >= '0' && c <= '9');
				int userNum3 = Convert.ToInt32(userNum2);
				//int userNum4 = PraticeClass3.AddedUserNum(userNum);
				//int userNum5 = PraticeClass3.AddedUserNum(userNum, userNum3);
				Console.WriteLine("Here is the output of this method : " + PraticeClass3.AddedUserNum(userNum, userNum3));

				if (!empty)
					Console.WriteLine(PraticeClass3.AddedUserNum(userNum));
			}
			 

				
				Console.ReadLine();
			
		}
	}
}
