
using System.Diagnostics;
using System.Numerics;
using System.Security.Cryptography;

namespace Demo.Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Img { get; set; }
        #region Overloading Binary Operators
        public static Complex operator +(Complex c1 , Complex c2)
            {
            //Complex c3 = new Complex()
            //{
            //    Real = c1.Real + c2.Real,
            //    Img = c1.Img + c2.Img
            //};
            //return c3;

            return new Complex()
            {
                Real = (c1?.Real??0) + (c2?.Real??0),
                Img = (c1?.Img??0) + (c2?.Img??0),
            };
            }
        public static Complex operator -(Complex c1 , Complex c2)
        {
            return new Complex()
            {
                Real = (c1?.Real??0) - (c2?.Real??0),
                Img = (c1?.Img??0) - (c2?.Img??0),
            };
        }
        #endregion
        #region Methods

        public override string ToString()
        {
            return $" {Real}  +  {Img}i";
        }

        #endregion
        #region Overloading Unary Operator
        public static Complex operator ++(Complex c)
        {
            return new Complex()
            {
                //Real = c?.Real + 1?? 1 ,
                Real = (c?.Real??0) + 1,
                Img = c?.Img??0
            };

        }
        public static Complex operator --(Complex c)
        {
            return new Complex()
            {
                Real = (c?.Real??0) - 1,
                Img = c.Img
            };
        }
        #endregion
        #region Overloading Relational operator
        // > < >= <=
        public static bool operator >(Complex Left , Complex Right)
        {
            if (Left.Real == Right.Real)
            {
                return Left.Img > Right.Img;
            }
            else
                return Left.Real > Right.Real;
        }
        public static bool operator <(Complex Left, Complex Right)
        {
            if (Left is null && Right is null)
            {
                return false;
            }
            else { 
            if (Left.Real == Right.Real)
            {
                return Left.Img < Right.Img;
            }
            else
                return Left.Real < Right.Real;
            }
        }
        #endregion

    }
}
