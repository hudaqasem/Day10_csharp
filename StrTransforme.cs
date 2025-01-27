using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Day10.Program;

namespace Day10
{
    internal class StrTransforme
    {
        
        public static string ToUpper(string str)
        {
            return str.ToUpper();
        }

        public static string ToLower(string str)
        {
            return str.ToLower();
        }

        public static string Reverse(string str)
        {
            string Result = "";
            for (int i = str.Length-1; i >=0 ; i--) 
                Result += str[i];
            return Result;
        }

        public static string[] TestTransforme(string[] str, TransformeDel transforme)
        {
            for (int i = 0; i < str.Length; i++)
                str[i] = transforme(str[i]);
            return str;
        }

        public static void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
