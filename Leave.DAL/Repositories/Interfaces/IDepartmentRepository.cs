using Leave.DAL.Models;
using Leave.DAL.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leave.DAL.Repositories.Interfaces
{
    public interface IDepartmentRepository : IRepository, IReadOnlyRepository<DepartmentModel>, IWriteOnlyRepositoryy<DepartmentModel> 
    {
    }
}
