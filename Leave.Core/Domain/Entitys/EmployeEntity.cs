using Leave.Core.Domain.Entitys.Base;

namespace Leave.Core.Domain.Entitys
{
    public class EmployeEntity: TEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
