using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentUpdated
{
    internal class Manager : Employee
    {
        //public new void ThatWork() // hide method
        //{
        //    Console.WriteLine("Manager is managing");
        //}
        public override void ThatWork() // override
        {
            Console.WriteLine("Manager is managing");
        }
    }
}
