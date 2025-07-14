using Demo.Binding;
using Demo.Overloading;
using Demo.Override;
using System.Runtime.Intrinsics.Arm;
namespace Demo
{
    internal class Program
    {
        #region Method Overloading
        //public static int SumNumbers(int x, int y)
        //{
        //    return x + y;
        //}
        //public static double SumNumbers(double x, int y)
        //{
        //    return x + y;
        //}
        //public static double SumNumbers(double x, double y)
        //{
        //    return x + y;
        //}
        //public static int SumNumbers(int x, int y, int z)
        //{
        //    return x + y;
        //}

        //public static double SumNumbers(double x, double y, double z)
        //{
        //    return x + y;
        //}


        #endregion
        #region Binding EX2
        //public static void ProcessOfEmployee(Full_Time employee)
        //{
        //    employee.GetEmployeeType();
        //    employee.GetEmployeeData();
        //}
        //public static void ProcessOfEmployee(Part_Time employee)
        //{
        //    employee.GetEmployeeType();
        //    employee.GetEmployeeData();
          
        //}
        //public static void ProcessOfEmployee(Employee employee)
        //{
        //    employee.GetEmployeeType(); // static binding [Method Hiding] --new  --compile-type --call method based on reference type
        //    employee.GetEmployeeData(); //Dynamic Binding [Method Override] -- virtual --run-time -- call method based on object type
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Method Overloading
            //int x = 10, y = 20, z = 30;
            //double a = 1.5, b = 3.5, c = 8.5;
            //SumNumbers(x, y);
            //SumNumbers(a, y);
            //SumNumbers(a, b);
            //SumNumbers(a, b, c);
            //SumNumbers(x, y, z);
            #endregion
            #region Operatores Overloading
            //Complex c1; // Declare variable -- take reference
            //c1 = new Complex();
            // allocate requiredbyte in heap
            // initalize default value
            // call user defined constructor
            // assign instance address to reference in stack
            //Complex c1 = new Complex() { Real = 4, Img = 5 };
            //Complex c2 = new Complex { Real = 10   , Img = 4};
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine();
            //Console.WriteLine(c1 + c2);// Overloading operators
            //Console.WriteLine(c1 - c2);// Overloading operators
            //Complex? c3 =default;
            //c3 += c1;
            //Console.WriteLine(c3);
            #endregion
            #region Overloading Operators [Unary Operator]
            // prefix ++x , postfix x++
            //Complex c1 = new Complex() { Real = 4 , Img = 10};
            //Console.WriteLine(c1);
            //c1++;
            //Console.WriteLine(" After ++");
            //Console.WriteLine(c1);
            //--c1;
            //Console.WriteLine("After --");
            //Console.WriteLine(c1);
            //Console.Write("c++ = ");
            //c1++;
            //Console.WriteLine(c1);
            //Console.Write("C-- =");
            //c1--;
            //Console.WriteLine(c1);

            #endregion
            #region Overloading Operators [Relational operators]
            //Complex c1 = new Complex { Real = 10, Img = 6 };
            //Complex c2 = new Complex { Real = 10, Img = 6 };
            //if (c1 > c2)
            //    Console.WriteLine("C1 > C2");
            //else if (c1 < c2)
            //    Console.WriteLine("C1 < C2");
            //else 
            //    Console.WriteLine("C1 = C2");
            #endregion
            #region Cating Operator Ex1
            //Complex c = new Complex() { Real = 6, Img = 9 };
            //int x = (int)c;
            //Console.WriteLine(x);
            //string str = c;
            //Console.WriteLine(str);
            #endregion
            #region Cating Operator Ex2
            //User user = new User()
            //{
            //    Id = 2202110,
            //    FullName = "Abdallah Sayed",
            //    Email = "abdallahsay10@gmail.com",
            //    Password = "p@sswOrd",
            //    SecurityStamp = Guid.NewGuid(),
            //};
            //UserViewModel userViewModel = (UserViewModel) user;
            //Console.WriteLine(userViewModel);
            #endregion
            #region Override
            //TypeA typeA = new TypeA(9);
            //typeA.A = 10; //Override 
            //Console.WriteLine(typeA);
            //typeA.Myfun1();
            //typeA.Myfun2();
            //TypeB typeB = new TypeB(10 , 20);
            //typeB.A = 20;
            //typeB.B = 30;
            //Console.WriteLine(typeB);
            //typeB.Myfun1();
            //typeB.Myfun2();


            #endregion
            #region Binding EX1
            //TypeA typeA = new TypeB(10 ,20);
            ////Take Referance from parent refer to an object from Child 
            //typeA.A = 20;
            ////typeA.B = 30;//Invalid
            //typeA.Myfun2();//Using keyword Override -- Object type , Late Binding -- CLR
            //typeA.Myfun1();// Using keyword new -- reference type -- early Binding - Rolson -- Hide method | Masking
                           //TypeB typeB = new TypeA(10);//Invalid
                           //try to take reference from Child refer to an object from parent   
            #endregion
            #region Binding EX2
            //Full_Time fullTime = new Full_Time(1000.5m, 20, 21, "Abdallah Sayed", "abdallahSay@gmail.com");
            ////fullTime.GetEmployeeType();
            ////fullTime.GetEmployeeData();
            //ProcessOfEmployee(fullTime);
            //Part_Time part_Time = new Part_Time(500, 8, 12, 21, "Abdol", "lukaSay10@gmail.com");
            //ProcessOfEmployee(part_Time);
            #endregion


        }
    }
}
