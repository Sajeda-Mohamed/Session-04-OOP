using Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Circle : ICircle
    {
        #region Properies
        public double Area { get { return Math.PI * Math.Pow(Radius, 2); } }

        public double Radius { get; set; }
        #endregion

        #region Constractors
        public Circle(double radius)
        {
            Radius = radius;
        }
        #endregion

        #region Methods
        
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Area of Circle is {Area}");
        } 
        #endregion
    }
}
