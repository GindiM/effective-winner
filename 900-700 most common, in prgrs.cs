using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 701, 800, 700, 800, 702, 803, 802, 703, 702, 701, 804, 805, 803, 803, 804, 805, 809, 708, 804, 803, 803, 900 };

            Console.WriteLine(MostCommon(arr));

        }

        static int MostCommon(int[] arr)
        {

            int big = 0;
            for (int i = 0; i < arr.Length; i++) //בודק מי האיבר הגדול
            {
                if (arr[i] > big)
                    big = arr[i];
            }
            int sml = big;
            for (int i = 0; i < arr.Length; i++) //בודק מי האיבר הקטן
            {
                if (arr[i] < sml)
                    sml = arr[i];
            }
            int[] Count = new int[big - sml +1]; //מחסר בין הגדול לקטן לצורך קביעת מערך 0-199+1 

            // מפה לתקן
            for (int i = 0; i < arr.Length; i++)
            {
                Count[arr[i]]++;
            }


            int BiggestIndex = 0;

            for (int i = 0; i < Count.Length; i++)
            {
                if (Count[i] > BiggestIndex)
                    BiggestIndex = i;
            }


            return BiggestIndex;
        }






    }
}
