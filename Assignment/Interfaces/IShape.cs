﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Interfaces
{
    internal interface IShape
    {
        #region Signature for Properties
        double Area { get; }
        #endregion

        #region Sigature for Methods
        void DisplayShapeInfo();
        #endregion
    }
}
