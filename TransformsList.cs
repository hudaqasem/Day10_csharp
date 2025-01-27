using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Day10.Program;

namespace Day10.Classes
{
    internal class TransformsList<T,TRes>
    {
        public static string ToStr(int X)
        {
            return X.ToString();
        }

        public static int ToInt(double X)
        {
            return (int)X;
        }

        public static int Square(int X)
        {
            return  X * X ;
        } 

        public static TRes[] TransformType(T[] arr, TransformTypeDel<T,TRes> TR)
        {
            TRes[] Res = new TRes[arr.Length];
            for (int i = 0;i < arr.Length;i++)
            {
                Res[i] = TR(arr[i]);
            }

            return Res;
        }

        public static int[] ApplySqrt(int[] arr, Func<int, int> TR)
        {
            int[] Res = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                Res[i] = TR(arr[i]);
            }

            return Res;
        }

    }
}
