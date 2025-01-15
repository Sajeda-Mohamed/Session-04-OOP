using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces
{
    internal interface IMyType
    {
        public int Salary { get; set; }// Signature for Property
        void MyFun();//Signature for Methods
        public void Print()
        {
            Console.WriteLine("Welcom from the default implemented Method");
        }
    }
    class MyType : IMyType
    {
        //private int salary;
        public int Salary { get; set; }//Auto Property

        public void MyFun()
        {
            Console.WriteLine("Hello Route"); ;
        }
    }
}
