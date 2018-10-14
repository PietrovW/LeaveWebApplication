using Leave.DAL.Models;
using Leave.DAL.Models.Base;
using Leave.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Leave.DAL.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public Task<ResultCode> AddAsync(DepartmentModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DepartmentModel>> AllAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DepartmentModel>> FindAllAsync(Expression<Func<DepartmentModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<DepartmentModel> FindAsync(Expression<Func<DepartmentModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<DepartmentModel> FindByIDAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultCode> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultCode> UpdateAsync(DepartmentModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
