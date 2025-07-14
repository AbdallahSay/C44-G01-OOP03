using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    internal class Full_Time : Employee
    {
        public decimal Salary { get; set; }
        public Full_Time(decimal salary , int id  , int age , string name , string email) :base(id , age , name , email)
        {
            Salary = salary;
        }
        public override void GetEmployeeData()
        {
            base.GetEmployeeData();
            Console.WriteLine($"  , Salary = {Salary}");
        }
        public new void GetEmployeeType()
        {
            Console.WriteLine("Hi I am Full-Time Employee");
        }
    }
}
