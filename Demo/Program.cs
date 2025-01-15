using Demo.Interfaces;
using System.Text;

namespace Demo
{
    internal class Program
    {
        //public static void Print10NumbersFromSeries(SeriesByTwo series)
        //{
        //    if (series is not null)
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.WriteLine(series.Current);
        //        }
        //        series.GetNext();
        //        series.Reset();
        //    }
        //}
        public static void Print10NumbersFromSeries(ISeries series)
        {
            if (series is not null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(series.Current);
                }
                series.GetNext();
                series.Reset();
            }
        }
        static void Main(string[] args)
        {
            #region Interface
            //IMyType myType = new IMyType();

            MyType myType = new MyType();
            //myType.MyFun();
            //myType.Salary = 6000;
            //myType.Print();

            IMyType myType1 = new MyType();
            //myType1.MyFun();
            //myType1.Salary = 6000;
            //myType1.Print();
            #endregion

            #region Interface Ex01
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //Print10NumbersFromSeries(seriesByTwo);

            //ISeries seriesByThree = new SeriesByThree();
            //Print10NumbersFromSeries(seriesByThree);
            #endregion

            #region Implicit & Explicit Implementation
            //AirPlane airPlane = new AirPlane();
            //airPlane.Forward

            //IFlyable AirPlane1 = new AirPlane();
            //AirPlane1.Forward();

            //IMovable AirPlane2 = new AirPlane();
            //AirPlane2.Forward();
            #endregion

            #region Shallow Copy & Deep Copy
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = new int[3]; // 0 0 0
            //Console.WriteLine($"Arr01 = {arr1.GetHashCode()}"); //54267293
            //Console.WriteLine($"Arr02 = {arr2.GetHashCode()}"); //18643596

            //Console.WriteLine("============================");
            //Shallow Copy 
            //arr2 = arr1;
            //Console.WriteLine($"Arr01 = {arr1.GetHashCode()}"); //54267293
            //Console.WriteLine($"Arr02 = {arr2.GetHashCode()}"); //54267293

            //arr1[0] = 10;
            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]);


            //Console.WriteLine($"Arr01 = {arr1.GetHashCode()}");
            //Console.WriteLine($"Arr02 = {arr2.GetHashCode()}");

            // Deep Copy
            
            //Console.WriteLine("==============================");
            //Console.WriteLine($"Arr01 = {arr1.GetHashCode()}");
            //Console.WriteLine($"Arr02 = {arr2.GetHashCode()}");

            //arr1[0] = 10;
            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]);

            //StringBuilder[] Name1 = new StringBuilder[1];
            //Name1[0] = new StringBuilder("Omar");
            //StringBuilder[] Name2 = new StringBuilder[1];

            //Console.WriteLine(Name1.GetHashCode()); //54267293
            //Console.WriteLine(Name2.GetHashCode()); //18643596
            ////Shallow Copy
            //Name2 = Name1;
            //Console.WriteLine(Name1.GetHashCode()); //54267293
            //Console.WriteLine(Name2.GetHashCode()); //54267293

            //Name2[0].Append(" Ahmed");
            //Console.WriteLine(Name1[0]);
            //Console.WriteLine(Name2[0]);

            //------------------------------------------------
            //StringBuilder[] Name1 = new StringBuilder[1];
            //Name1[0] = new StringBuilder("Omar");
            //StringBuilder[] Name2 = new StringBuilder[1];

            //Console.WriteLine(Name1.GetHashCode()); //54267293
            //Console.WriteLine(Name2.GetHashCode()); //18643596
            //Console.WriteLine("=================================");
            //Name2 = (StringBuilder[])Name1.Clone();

            //Console.WriteLine(Name1.GetHashCode()); //54267293
            //Console.WriteLine(Name2.GetHashCode()); //18643596

            //Console.WriteLine(Name1[0]);
            //Console.WriteLine(Name2[0]);

            //Name2[0].Append("Ahmed");
            //Name1[0].Append("Ahmed");
            #endregion

        }
    }
}
