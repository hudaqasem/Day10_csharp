using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10.Classes
{
    internal class FilterString
    {
        public static string[] Filter(string[] str , Predicate<string> Flag)
        {
            int cnt = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Flag(str[i]))
                cnt++;
            }
            string[] Arr = new string[cnt];
            for (int i = 0 , j = 0; i < str.Length; i++)
            {
                if (Flag(str[i]))
                {
                    Arr[j] = str[i];
                    j++;
                }          
            }
            return Arr;
        }
    }
}
