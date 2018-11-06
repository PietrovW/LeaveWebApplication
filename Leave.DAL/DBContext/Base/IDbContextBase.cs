using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Leave.DAL.Context.Base
{
    public interface IDbContextBase : IDisposable
    {
        SqlTransaction BeginTransaction();
        SqlConnection Connection();
        void Commit();
        void Rollback();
    }
}
