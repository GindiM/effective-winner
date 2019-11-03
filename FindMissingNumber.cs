using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 5, 6, 8, 9, 10, 11 }; // size = 6, 0-5
			int[] arr2 = { 1, 2, 3, 4, 5, 6 };
			int[] arr3 = { 67, 68, 69, 71, 72, 73 };



			Console.WriteLine(MissingNumber(arr3));



		}

		static int MissingNumber(int[] a)
		{
			int Smallest = Biggest(a)-a.Length; //one of the arr spots is missing so, -1 is not usable
			int OrigSum = 0;
			int NewSum = 0;

			int[] NewArr = new int[a.Length + 1];

			for (int i = 0; i < a.Length+1; i++) // new spot for missing number
			{
				NewArr[i] = Smallest + i; // filling up the new array
				NewSum = NewSum + NewArr[i]; //summing the new array
			}

			for (int i = 0; i < a.Length; i++)
			{
				OrigSum = OrigSum + a[i];
			}




			return NewSum-OrigSum;
		}









		static int Biggest(int[] a)
		{
			int big = 0;

			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] > big)
					big = a[i];

			}

			return big;
		}

	}
}
