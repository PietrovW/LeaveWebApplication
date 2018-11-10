using Leave.Core.Entitys.Base;

namespace Leave.Core.Entitys
{
    public class EmployeEntity: TEntity
    {
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public string Salt { get; protected set; }
        public string Username { get; protected set; }
        public string FullName { get; protected set; }
        public string Role { get; protected set; }
    }
}
