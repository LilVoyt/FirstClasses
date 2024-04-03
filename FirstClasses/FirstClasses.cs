using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public static class Practice
    {
        //Ex 1
        public static int MultiplyDiapasone(int start, int end)
        {
            int res = 1;
            for (int i = start; i <= end; i++)
            {
                res *= i;
            }
            return res;
        }

        //Ex 2
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        //Ex 3
        public static int[] SortArr(ref int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }

    }
}
