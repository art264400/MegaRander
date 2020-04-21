using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculateForMegaRender.Models
{
    public class Matrix
    {
        public int[,] X { get; set; }
        public int[,] Y { get; set; }
        public int Result { get; set; }

        public virtual double? Action()
        {
            return null;
        }
    }

    public class Multiplication : Matrix
    {
        //public override double Action()
        //{

        //    return X[1] * Y[2];
        //}
    }

    public class Summation : Matrix
    {
        //public override double Action()
        //{
        //    return X[1] * Y[2];
        //}
    }


}