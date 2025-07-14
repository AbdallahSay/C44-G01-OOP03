using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentUpdated
{
    internal class Employee
    {
        //public void ThatWork()
        //{
        //    Console.WriteLine("Employee is workig"); //Can not override
        //}
        public virtual void ThatWork() //Can override
        {
            Console.WriteLine("Employee is workig");
        }
    }
}
