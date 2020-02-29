using System;
using System.Collections.Generic;

namespace Lab_1
{
    public static class Module1
    {
        public static bool CheckList(List<int> list)
        {
            if (!(list.Count > 0 && list.Count < 10)) return false;//throw new Exception("Введено неверное количество чисел!");
            foreach (var item in list)
            {
                if (item < 99 || item > 1000) return false;//throw new Exception("Введено число не удовлетворяющему условию: все числа массива должны быть трехзначными!");
            }
            return true;
        }
        public static List<int> ConvertStringInInt(string[] str)
        {
            List<int> listNumbers = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                listNumbers.Add(Convert.ToInt32(str[i]));
            }
            return listNumbers;
        }
        public static string[] ConvertStringInMasString(string str)
        {
            return str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string ConvertListInString(List<int> list)
        {
            string str = "";
            foreach(int item in list)
            {
                str = str + Convert.ToString(item) + ' ';
            }
            if (!string.IsNullOrEmpty(str))
                str = str.TrimEnd(' ');
            return str;
        }
    }
}
    