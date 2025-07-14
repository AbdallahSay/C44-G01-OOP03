using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Calculator
    {
        //public int X { get; set; }
        //public int y { get; set; }
        //public int Z { get; set; }
        //public decimal A { get; set; }
        //public decimal B { get; set; }
        public int SumNumbers(int x , int y)
        {
            return x + y;
        }
        public int SumNumbers(int x , int y , int z)
        {
            return x + y + z;
        }
        public double SumNumbers(double x , double y)
        {
            return x + y;
        }
    }
}
