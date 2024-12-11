using System.ComponentModel;

namespace Demo_C_
{
    internal class Program
    {

        static int Sum(int X , int Y)
        {
            return X - Y;
        }
        static void Main(string[] args)
        {
            #region Error Types
            #region Syntax Erroe - Copilation Error
            // console.WriteLine("Hello world");
            // iint X;

            #endregion
            #region RunTime Error
            //int x = 5;
            // int y = 0;
            // Console.WriteLine(x / y);
            #endregion
            #region Logical Error
            // int A = 10;
            //  int B = 20;
            // Console.WriteLine(Sum(A,B));
            #endregion
            #region Warning
            // int X = 5;
            // Console.WriteLine(X);
            #endregion
            #endregion
            #region Varible
            // int Number = 5;
            #endregion
            #region CTS - CLS
            // int X = 5; //4bytes

            // String Name = "test"; // 8 Byte
            // Name = "Ali"; // 6byte
            #endregion
            #region ValueType
            //nt X;// 4 byte

            //Console.WriteLine(X);
            //X = 4;
            //int Y = 9;
            // Y = X;
            //X++;
            //Console.WriteLine(X);
            //Console.WriteLine(Y);

            #endregion
            #region Reference Type
            Point P01;
            P01 = new Point();    

             Point P02 = new Point();

            P02 = P01;

            P01.x = 10;
             Console.WriteLine(P02.x);
            #endregion
            #region Object
            // Point P01 = new Point();
            // object obj01 = new object();
            // object obj02 = new object();

            // Console.WriteLine(obj01.GetHashCode());
            // Console.WriteLine(obj02.GetHashCode());

            // obj02 = obj01;
            // Console.WriteLine("************************");
            // Console.WriteLine(obj01.GetHashCode());
            // Console.WriteLine(obj02.GetHashCode());
            #endregion
            #region Fractions And Discard
            int num01 = 123412412;
            long num02 = 234235235;

            double Num03 = 22.2;
            float num04 = 22.2f;
            decimal Num05 = 22.2m;

            int Num06 = 1_000_000_000;
            Console.WriteLine(Num06);
            #endregion
        }
    }
}
