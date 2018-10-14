using Leave.DAL.Models.Base;
using System;

namespace Leave.DAL.Models
{
    public class RecordModel : TEntity
    {
        public int EmployeId { get; set; }
        public int FurloughId { get; set; }
        public int DepartmentId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
