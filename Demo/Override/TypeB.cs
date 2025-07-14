using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Override
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int a , int b) : base(a)
        {
            B = b;
        }
        public override string ToString()
        {
            return base.ToString() + $" ,  B = {B}"
            ;
        }
        public override void Myfun2() // Dynamic polymorphis
        {
            Console.WriteLine("Hello I am Child"); ;
        }
        public new  void Myfun1() //Masking -- Static Polymorphism
        {
            Console.WriteLine($"TypeB  A = {A} , B = {B} ");
        }

    }
}
