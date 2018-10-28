﻿using Leave.DAL.Context.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Leave.DAL.Repositories.Base
{
    public abstract class BaseRepository
    {
        private readonly IDbContextBase _dbContext;
        protected readonly string TableName;

        public BaseRepository(IDbContextBase dbContext, string tableName)
        {
            _dbContext = dbContext;
            TableName = tableName;

        }
    }
}
