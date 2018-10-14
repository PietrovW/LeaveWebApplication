using Leave.Infrastructure.Commands.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leave.Infrastructure.Commands.Employes
{
    public class CreateUser : ICommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }

    }
}
