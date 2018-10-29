using Leave.DAL.Context.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Leave.DAL.Repositories.Base
{
    public abstract class BaseRepository
    {
        private readonly IDbContextBase _dbContext;
        protected readonly string TableName;

        protected SqlTransaction Transaction { get; }
        protected SqlConnection Connection { get; }

        public BaseRepository(IDbContextBase dbContext, string tableName)
        {
            _dbContext = dbContext;
            TableName = tableName;
            Connection = dbContext.Connection();
            Transaction = _dbContext.BeginTransaction();
        }
    }
}
