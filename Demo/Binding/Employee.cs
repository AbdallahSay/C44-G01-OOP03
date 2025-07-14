using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    internal class Employee
    {


        public int Id { get; set; }
        public int Age { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        #region Ctor
        public Employee(int id, int age, string? name, string? email)
        {
            Id = id;
            Age = age;
            Name = name;
            Email = email;
        }
        public Employee() { }
        #endregion
        #region Methods
        public void GetEmployeeType() 
        {
            Console.WriteLine("Hi I am Employee");
        }
        public virtual  void GetEmployeeData()
        {
            Console.Write($"Id = {Id} , Age = {Age} , Name = {Name}  , Email = {Email}");
        }
        #endregion
    }
}
