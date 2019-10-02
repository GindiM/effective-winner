using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
	class Program
	{
		static void Main(string[] args)
		{

			int[] arr = { 1, 2, 3 };
			int temp;
			int r = 2;




			for (int l = 0; l < 3; l++)
			{


				for (int i = 0; i < 3; i++)
				{



					if (i != r)
					{
						temp = arr[r];
						arr[r] = arr[i];
						arr[i] = temp;
						Console.Write(arr[0]);
						Console.Write(arr[1]);
						Console.WriteLine(arr[2]);
					}


				}











			}
		}
	}
}
