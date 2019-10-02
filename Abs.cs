using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = -5;
			int a, b;
			Console.WriteLine(DisB(5, 10));


		}






		static int DisB(int a, int b)
		{

			int i = 0;

			if (a < b)

				while (a != b)
				{
					a++;
					i++;
				}

			else

				while (b != a)
				{
					b++;
					i++;
				}

			return i;


		}




	static int DisA(int a, int b)
	{
		int c = a - b;


			return c > 0 ? c : (c < 0 ? -c : 0);

	}






}
}
