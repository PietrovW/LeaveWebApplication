using Leave.Infrastructure.Commands.Base;

namespace Leave.Infrastructure.Commands.Users
{
    public class ChangeUserPassword : ICommand
    {
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
