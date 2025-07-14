using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Override
{
    internal class TypeA
    {
        public int A { get; set; }
        public TypeA(int a)
        {
            this.A = a;
        }
        public void Myfun1() 
        {
            Console.WriteLine("Hello I am Base");
        }
        public virtual void Myfun2() 
        {
            Console.WriteLine($"Type A -___> A = {A}");
        }
        public override string ToString()
        {
            return $"A = {A}"
            ;
        }

    }
}
