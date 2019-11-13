using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {               // 0   1   2  3  4  5  6  7  8     size = 9
            int[] arr = { -5, -2, -1, 2, 3, 5, 7, 8, 11 };

            Console.WriteLine(IndexEqualsValue(arr, 8));
            Console.ReadKey();


        }


        static int IndexEqualsValue(int[] arr, int i)
        {



            if (i == 0 && i != arr[i])
                return -1;

            if (arr[i] == i)
                return i;



            return (IndexEqualsValue(arr, i - 1));




        }
    }
}
