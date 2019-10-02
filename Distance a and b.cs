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
			Console.WriteLine(TimesB(1, 11));
			Console.WriteLine(TimesA(1, 11));

		}





		static int TimesB(int a, int b)
		{



			int j = 0;
			int sum = 0;
			bool brk = false;


			if (a == 0 || b == 0)
				brk = true;

			if (brk == false)
			{
				for (int i = 0; i < a; i++)
				{

					sum = sum + b;

				}
			}

			return sum;



		}











		static int TimesA(int a, int b)
		{

			

			int j = 0;
			int sum = 0;
			bool brk = false;


			if (a == 0 || b==0) 
				brk = true;
			


			if (brk == false)
			{
				for (int i = 0; i < a; i++)
				{

					while (j < b)
					{

						j++;
					}
					sum = sum + j;

				}
			}

			return sum;



		}









	}
}
