using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice3
{
	public class PraticeClass3
	{
		public static int AddedUserNum(int j)
		{
			return j + 10;
		}

		public static int AddedUserNum(int j, int k = 0)
		{
			return (j + 10) + k;
		}
	}
}
