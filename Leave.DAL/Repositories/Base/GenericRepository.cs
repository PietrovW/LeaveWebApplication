using Leave.DAL.Context.Base;
using Leave.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using Dapper;
using System.Threading.Tasks;
using Leave.DAL.Extensions;
using Leave.Core.Entitys.Base;

namespace Leave.DAL.Repositories.Base
{
    public abstract class GenericRepository<T> : BaseRepository, IRepository<T> , IDisposable where T : TEntity
    {

        public GenericRepository(IDbContextBase dbContext, string tableName) : base(dbContext, tableName)
        {
        }

        public virtual async Task<Tuple<ReturnCode, T>> AddAsync(T entity)
        {
            var parameters = (object)Mapping(entity);

            Tuple<ReturnCode, T> returnCode = await Connection.InsertAsync<T>(TableName, parameters);
            return returnCode;
        }

        public virtual async Task<IEnumerable<T>> AllAsync()
        {
            IEnumerable<T> items = null;

            items = await this.Connection.SelectAsync<T>(TableName);
            return items;
        }
      
        public virtual async Task<ReturnCode> RemoveAsync(int id)
        {
            ReturnCode returnCode = await Connection.ExecuteNonQueryAsync("DELETE FROM " + this.TableName + " WHERE ID=@ID", new { Id = id });
            return returnCode;
        }

        public virtual async Task<ReturnCode> UpdateAsync(T entity)
        {
            var parameters = (object)Mapping(entity);
            ReturnCode returnCode= await Connection.UpdateAsync(TableName, parameters);
            return returnCode;
        }

        public virtual async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> items = null;

            items = await Connection.SelectAsync<T>(TableName, predicate);

            return items;
        }

        internal virtual dynamic Mapping(T item)
        {
            return item;
        }

        public void Dispose()
        {
            this.Transaction.Dispose();
            this.Connection.Dispose();
        }
    }
}
