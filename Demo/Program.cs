namespace Demo
{
    internal class Program
    {
        #region Method Overloading
        public static int SumNumbers(int x, int y)
        {
            return x + y;
        }
        public static double SumNumbers(double x, int y)
        {
            return x + y;
        }
        public static double SumNumbers(double x, double y)
        {
            return x + y;
        }
        public static int SumNumbers(int x, int y, int z)
        {
            return x + y;
        }

        public static double SumNumbers(double x, double y, double z)
        {
            return x + y;
        }


        #endregion

        static void Main(string[] args)
        {
            #region Method Overloading
            int x = 10, y = 20, z = 30;
            double a = 1.5, b = 3.5, c = 8.5;
            SumNumbers(x, y);
            SumNumbers(a, y);
            SumNumbers(a, b);
            SumNumbers(a, b, c);
            SumNumbers(x, y, z);
            #endregion

        }
    }
}
