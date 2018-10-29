using Leave.DAL.Context.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Leave.DAL.Context
{
    public class DbContextBase : IDbContextBase
    {
        private SqlConnection _connection;
        private SqlTransaction _transaction;

        public DbContextBase(IConnectionFactory connectionFactory)
        {
            _connection = new SqlConnection(connectionFactory.ConnectionString);
            _transaction = _connection.BeginTransaction();
        }
        public SqlConnection Connection() => _connection;

        public SqlTransaction BeginTransaction() => _transaction;

        public void Commit() => _transaction.Commit();

        public void Rollback()
        {
            _transaction.Dispose();
            _transaction.Rollback();
        }
        public void Dispose()
        {
            _connection.Dispose();
        }

    }
}
