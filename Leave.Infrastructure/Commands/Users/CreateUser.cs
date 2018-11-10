using Leave.Infrastructure.Commands.Base;

namespace Leave.Infrastructure.Commands.Users
{
    public class CreateUser : ICommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }

    }
}
