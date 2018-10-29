using Leave.DAL.Context.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leave.DAL.Context
{
    public class ConnectionFactory : IConnectionFactory
    {
        public string ConnectionString
        {
            get { return "YourConStringName"; }
        }
    }
}
