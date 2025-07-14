using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class UserViewModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public static explicit operator UserViewModel(User user)
        {
            UserViewModel userViewModel = new UserViewModel()
            {
                Id = user.Id,
                Email = user.Email,

            };
            string[]? names = user?.FullName?.Split(" ");
            if(names is not null && names.Length >= 2)
            {
                userViewModel.FirstName = names[0];
                userViewModel.LastName = names[1];
            }
            else
            {
                userViewModel.FirstName = string.Empty;
                userViewModel.LastName = string.Empty;
            }
            return userViewModel;
        }
        public override string ToString()
        {
            return $"Id = {Id} , First Name = {FirstName} , LastName = {LastName}  , Email = {Email}";
        }
    }
}
