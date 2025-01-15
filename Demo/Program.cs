using Demo.Interfaces;

namespace Demo
{
    internal class Program
    {
        
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

        }
    }
}
