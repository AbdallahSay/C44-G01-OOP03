using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    internal class Part_Time : Employee
    {
        public int HourRate { get; set; }
        public int CountOfHours { get; set; }
        public Part_Time(int hourRate, int countOfHours , int id , int age , string name , string email) : base(id , age , name , email)
        {
            HourRate = hourRate;
            CountOfHours = countOfHours;
        }
        public override void GetEmployeeData()
        {
            base.GetEmployeeData();
            Console.WriteLine($"  ,  Hour Rate = {HourRate} , Count Of Hours = {CountOfHours}");
        }
        public new void GetEmployeeType()
        {
            Console.WriteLine("Hi I am Part-Time Employee");
        }
       
       
    }
}
