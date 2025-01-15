using Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Rectangle : IRectangle
    {
        #region Properties
        public double Area { get { return Width * Hight; } }
        public double Width { get; set; }
        public double Hight { get; set; }
        #endregion

        #region Constractors
        public Rectangle(Double width, double hight)
        {
            Width = width;
            Hight = hight;
        }

        #endregion

        #region Methods
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Area of Rectangle is {Area}");
        } 
        #endregion
    }
}
