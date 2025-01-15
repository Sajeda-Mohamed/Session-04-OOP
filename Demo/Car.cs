using Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car : IMovable
    {
        public void Forward()
        {
            Console.WriteLine("Move Forward on Gound"); ;
        }
    }
}
