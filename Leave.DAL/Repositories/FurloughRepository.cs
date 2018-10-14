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
    public class FurloughRepository : IFurloughRepository
    {
        public Task<ResultCode> AddAsync(FurloughModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FurloughModel>> AllAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FurloughModel>> FindAllAsync(Expression<Func<FurloughModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<FurloughModel> FindAsync(Expression<Func<FurloughModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<FurloughModel> FindByIDAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultCode> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultCode> UpdateAsync(FurloughModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
