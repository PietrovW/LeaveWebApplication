using Leave.Core.Domain.Entitys.Base;
using System;

namespace Leave.Core.Domain.Entitys
{
    public class RecordEntity : TEntity
    {
        public int EmployeId { get; set; }
        public int FurloughId { get; set; }
        public int DepartmentId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
