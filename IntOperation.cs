using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Day10.Program;

namespace Day10
{
    internal class IntOperation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return (b != 0) ? (a / b) : 0 ;
        }

        public static int performOperation(int a, int b, OperationDel op)
        {
            return op(a, b);
        }

        public static bool IsEven(int a)
        {
            return (a % 2 == 0);
        }

        //public static int MathOp(int a, int b , Func<int , int , int> Op)
        //{
        //    return Op(a, b);
        //}

        public static T MathOp<T>(T a, T b, Func<T, T, T> Op)
        {
            return Op(a, b);
        }
    }
}
