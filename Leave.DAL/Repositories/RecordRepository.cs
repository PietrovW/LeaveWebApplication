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
    public class RecordRepository : IRecordRepository
    {
        public Task<ResultCode> AddAsync(RecordModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RecordModel>> AllAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RecordModel>> FindAllAsync(Expression<Func<RecordModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<RecordModel> FindAsync(Expression<Func<RecordModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<RecordModel> FindByIDAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultCode> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultCode> UpdateAsync(RecordModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
