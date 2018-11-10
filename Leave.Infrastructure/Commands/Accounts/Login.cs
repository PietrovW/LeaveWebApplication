using Leave.Infrastructure.Commands.Base;
using System;

namespace Leave.Infrastructure.Commands.Accounts
{
    public class Login : ICommand
    {
        public Guid TokenId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
