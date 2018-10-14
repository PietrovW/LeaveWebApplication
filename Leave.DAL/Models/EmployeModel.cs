using Leave.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leave.DAL.Models
{
    public class EmployeModel: TEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
