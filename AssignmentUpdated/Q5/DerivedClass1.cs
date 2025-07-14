using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentUpdated.Q5
{
    internal class DerivedClass1 : BaseClass
    {
        public override void DisplayMessage()
        {
            //base.DisplayMessage(); //print message from BaseClass
            Console.WriteLine("Message From DerivedClass1");
        }
    }
}
