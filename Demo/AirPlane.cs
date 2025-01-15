using Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class AirPlane : IMovable, IFlyable
    {
        void IMovable.Forward()
        {
            Console.WriteLine("Move Forward on Ground"); ;
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Move Forward on Air");
        }
    }
}
