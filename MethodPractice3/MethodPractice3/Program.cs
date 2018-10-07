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
			
			Console.WriteLine("Please enter a number between 1-50");
			int userNum = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter another number between 1-50 or don't.  You don't have to if you don't want to.");
			int userNum2 = Convert.ToInt32(Console.ReadLine());
			

			
			int userNum3 = PraticeClass3.AddedUserNum(userNum, userNum2);
			Console.WriteLine("Here is the output of this method : Your first number is now : " + userNum3);
			Console.ReadLine();

		}
	}
}
