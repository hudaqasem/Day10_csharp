using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class SortingAlgorithm<T> where T : IComparable<T> , ICloneable
    {
        public static void Sort(T[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                        Swap(ref arr[j], ref arr[j + 1]);
                }
            }
        }

        public static void Swap(ref T a, ref T b) 
        {
            T Temp = a;
            a = b;
            b = Temp;
        }

        public static T[] CloneArr(T[] arr)
        {
            T[] temp = new T[arr.Length];
            for (int i = 0;i < arr.Length; i++) 
                temp[i] = (T) arr[i].Clone();
            return temp;
        } 

    }
}
