using Day10.Classes;
using static Day10.Program;

namespace Day10
{
    internal class Program
    {
        // step 0 declare delegate takes a string and returns a string
        public delegate string TransformeDel(string str);

        //two integers and returns an integer
        public delegate int OperationDel(int A, int B);

        //parameter of type T and returns a value of type R
        public delegate TRes TransformTypeDel<in T, out TRes>(T X);






        static void Main(string[] args)
        {
            #region generic sorting 
            //Employee[] Emps =
            //{
            //    new Employee(1,"Ali",5000),
            //    new Employee(2,"Soly",3000),
            //    new Employee(3,"Ismail",3500),
            //};
            //Console.WriteLine("Emps Before Sort by salary : ");
            //foreach (Employee item in Emps)
            //    Console.WriteLine(item);

            //SortingAlgorithm<Employee>.Sort(Emps);

            //Console.WriteLine("Emps After Sort by salary : ");
            //foreach (Employee item in Emps)
            //    Console.WriteLine(item);
            #endregion

            #region Dynamic sort Asc || Desc
            //int[] Nums = { 1, 2, 50, 5, 60 };
            //Console.WriteLine("Nums After Sort descending: ");
            //SortingTwo<int>.Sort(Nums, (int X, int Y) => X < Y);
            //foreach (int Num in Nums)
            //{
            //    Console.WriteLine(Num);
            //}

            //string[] S = { "aa" , "and" , "a" , "aabb" };
            //Console.WriteLine("Strings After Sort bu length Asc : ");
            //SortingTwo<string>.Sort(S,( X , Y) => X.Length > Y.Length);
            //foreach (string item in S) 
            //{
            //    Console.WriteLine(item);
            //} 

            //int[] Nums1 = { 1, 2, 50, 5, 60 };
            //Console.WriteLine("Nums After Sort ascending: ");
            //SortingTwo<int>.Sort(Nums1, (int X, int Y) => X > Y);
            //foreach (int Num in Nums1)
            //{
            //    Console.WriteLine(Num);
            //}


            #endregion

            #region Manager sort
            //Manager[] M1 = {
            //    new Manager(1 , "Aisha" , 80000 , "010"),
            //    new Manager(2 , "Nada" , 20000 , "011"),
            //    new Manager(3 , "Alaa" , 95000 , "012"),
            //    new Manager(4 , "Hagar" , 60000 , "015")
            //}; 
            //SortingAlgorithm<Manager>.Sort(M1);
            //Console.WriteLine("Mgr After Sory By sal : ");
            //foreach (Manager manager in M1)
            //    Console.WriteLine(manager); 
            #endregion

            #region Sort emp by name
            //Employee[] Emps =
            //{
            //    new Employee(1,"Aisha",5000),
            //    new Employee(2,"Soly",3000),
            //    new Employee(3,"Ali",3500),
            //};
            //Console.WriteLine("Emps Before Sort by Length : ");
            //foreach (Employee item in Emps)
            //    Console.WriteLine(item);

            //SortingTwo<Employee>.Sort(Emps,(E1 , E2) => E1.Name.Length > E2.Name.Length);
            //Console.WriteLine("Emps After Sort by Length : ");
            //foreach (Employee item in Emps)
            //    Console.WriteLine(item); 
            #endregion

            #region DefaultValue
            //Console.WriteLine($"Default int: {DefaultValue.GetDefault<int>()}");       
            //Console.WriteLine($"Default double: {DefaultValue.GetDefault<double>()}"); 
            //Console.WriteLine($"Default bool: {DefaultValue.GetDefault<bool>()}");
            //Console.WriteLine($"Default bool: {DefaultValue.GetDefault<string>()}");
            #endregion

            #region ICloneable
            //Employee[] Emps =
            //{
            //    new Employee(1,"Ali",5000),
            //    new Employee(2,"Soly",3000),
            //    new Employee(3,"Ismail",3500),
            //};

            //Employee[] Copy = SortingAlgorithm<Employee>.CloneArr(Emps);
            //SortingAlgorithm<Employee>.Sort(Emps);

            //Console.WriteLine("Emps Before Sort : ");
            //foreach (Employee item in Copy)
            //    Console.WriteLine(item);

            //Console.WriteLine("Emps After Sort : ");
            //foreach (Employee item in Emps)
            //    Console.WriteLine(item);

            #endregion

            #region StrTransforme
            //string[] Str1 = { "ali" , "AHMED" , "Omar" };
            //// step 1,2 declare ref from my delegate transformeDel & initialize del to function
            //TransformeDel ToUpperStr = StrTransforme.ToUpper;
            //TransformeDel ToLowerStr = StrTransforme.ToLower;
            //TransformeDel ReversedStr = StrTransforme.Reverse;

            //string[] Test = new string[Str1.Length];


            //Test = StrTransforme.TestTransforme(Str1, ToUpperStr);
            //foreach (string str in Test)
            //    Console.WriteLine(str);

            //Console.WriteLine("***********************************");

            //Test = StrTransforme.TestTransforme(Str1, ToLowerStr);
            //foreach (string str in Test)
            //    Console.WriteLine(str);

            //Console.WriteLine("***********************************");

            //Test = StrTransforme.TestTransforme(Str1, ReversedStr);
            //foreach (string str in Test)
            //    Console.WriteLine(str); 
            #endregion

            #region IntOperations
            //OperationDel Add = IntOperation.Add;
            //OperationDel Sub = IntOperation.Sub;
            //OperationDel Mul = IntOperation.Multiply;
            //OperationDel Div = IntOperation.Divide;

            //Console.WriteLine($"4 + 2 = {Add(4,2)}");
            //Console.WriteLine($"4 - 2 = {Sub(4,2)}");
            //Console.WriteLine($"4 * 2 = {Mul(4,2)}");
            //Console.WriteLine($"4 / 2 = {Div(4,2)}"); 
            #endregion

            #region TransformList & SuareArr
            //int[] Arr = { 1, 2, 3 };
            //double[] Arr2 = { 1.5, 2.3, 4.5 };

            //TransformTypeDel<int, string> IntToStr = TransformsList<int, string>.ToStr;
            //TransformTypeDel<double, int> DobleToInt = TransformsList<Double, int>.ToInt;

            //string[] Res1 = TransformsList<int, string>.TransformType(Arr,IntToStr);  
            //int[] Res2 = TransformsList<double, int>.TransformType(Arr2,DobleToInt);


            //foreach (string i in Res1)
            //    Console.WriteLine(i);

            //Console.WriteLine("**************************");

            //foreach (int i in Res2)
            //    Console.WriteLine(i); 

            ////int[] StrRes = TransformsList<int,int>.ApplySqrt(Arr,TransformsList<int,int>.Square);
            //int[] StrRes = TransformsList<int, int>.ApplySqrt(Arr, (T) => T * T);
            //foreach (int i in StrRes)
            //    Console.WriteLine(i);


            #endregion

            #region Action & Predicate Delegates
            //Action<string> PrintDel = StrTransforme.Print;
            //PrintDel.Invoke("Hi :) "); 

            //Predicate<int> IsEven = IntOperation.IsEven;
            //Console.WriteLine($"5 is even ? {IsEven.Invoke(5)} , 4 is even ? {IsEven.Invoke(4)}");

            #endregion

            #region filters a list anonymous & lambda
            //string[] Str = { "Ali", "Nada", "Huda", "Ahmed" };
            //Predicate<string> An1 = delegate (string s) { return s.StartsWith('H'); };
            //Predicate<string> An2 = delegate (string s) { return s.Contains("da"); };

            //string[] StartWithAnonymous = FilterString.Filter(Str, An1);
            //string[] Contain = FilterString.Filter(Str, An2);

            //foreach (string str in StartWithAnonymous)
            //    Console.WriteLine(str);

            //Console.WriteLine("-----------------------------");

            //foreach (string str in Contain)
            //    Console.WriteLine(str);

            //Console.WriteLine("-------------Lambda----------------");

            //string[] StartWithLambda = FilterString.Filter(Str, (S) => S.StartsWith('A'));
            //string[] ContainLambda = FilterString.Filter(Str, (S) => S.Contains("da"));

            //foreach (string str in StartWithLambda)
            //    Console.WriteLine(str);

            //Console.WriteLine("-----------------------------");

            //foreach (string str in ContainLambda)
            //    Console.WriteLine(str);
            #endregion

            #region  mathematical operation Int & double
            //Console.WriteLine("------Int Operations");
            //int Add = IntOperation.MathOp<int>(5, 5, (A, B) => A + B);
            //int Sub = IntOperation.MathOp<int>(5, 5, (A, B) => A - B);
            //int Mul = IntOperation.MathOp<int>(5, 5, (A, B) => A * B);
            //int Div = IntOperation.MathOp<int>(5, 5, (A, B) => A / B);

            //Console.WriteLine($"5 + 5 = {Add}");
            //Console.WriteLine($"5 - 5 = {Sub}");
            //Console.WriteLine($"5 * 5 = {Mul}");
            //Console.WriteLine($"5 / 5 = {Div}");

            //Console.WriteLine("------double Operations");
            //double Add2 = IntOperation.MathOp<double>(5.5, 4.5, (A, B) => A + B);
            //double Sub2 = IntOperation.MathOp<double>(5.5, 5.5, (A, B) => A - B);
            //double Mul2 = IntOperation.MathOp<double>(1.5, 1, (A, B) => A * B);
            //double Pow = IntOperation.MathOp<double>(2.2, 2, (A, B) => Math.Pow(A,B));

            //Console.WriteLine($"5 + 5 = {Add2}");
            //Console.WriteLine($"5.5 - 5.5 = {Sub2}");
            //Console.WriteLine($"1.5 * 1 = {Mul2}");
            //Console.WriteLine($"2.2 ^ 2 = {Pow}");


            #endregion















        }
    }
}
