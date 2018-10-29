using System;
using System.Collections.Generic;
using System.Text;

namespace Leave.DAL.Helper
{
    public class QueryResult
    {
        private readonly (string, dynamic) _result;

        public string Sql
        {
            get
            {
                return _result.Item1;
            }
        }


        public dynamic Param
        {
            get
            {
                return _result.Item2;
            }
        }

        public QueryResult(string sql, dynamic param)
        {
            _result = (sql, param);
        }
    }
}
