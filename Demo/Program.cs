using Demo.Interfaces;

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

            SeriesByThree seriesByThree = new SeriesByThree();
            Print10NumbersFromSeries(seriesByThree);
            #endregion
        }
    }
}
