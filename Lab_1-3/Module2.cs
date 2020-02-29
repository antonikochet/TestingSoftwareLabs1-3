using System;
using System.Collections.Generic;

namespace Lab_1
{
    public static class Module2
    {
        
        public static bool SimpleNumber(int number)
        {
            bool simple = true;
            if (number <= 1) return false;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    simple = false;
                    break;
                }
            }
            return simple;
        }
        public static int ToAddOne(int number)
        {
            return ++number;
        }

        public static bool IsPowerOfTwo(int val)
        {
            return val != 0 && (val & (val - 1)) == 0;
        }

        public static double DetermitePowerNumber(int number)
        {
            return Math.Log(number, 2);
        }
        public static bool MainCondition(int number)
        {
            return (SimpleNumber(number) && IsPowerOfTwo(ToAddOne(number)) && SimpleNumber(Convert.ToInt32(DetermitePowerNumber(ToAddOne(number)))));
        }

        public static List<int> MainsFor(List<int> list)
        {
            
            List<int> newList = new List<int>();
            foreach (var item in list)
            {
                if (!MainCondition(item))
                    newList.Add(item);
            }
            return newList;
        }
    }
}
