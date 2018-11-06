using Leave.DAL.Context.Base;

namespace Leave.DAL.Context
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly string connectionString;
        private readonly SqlSettings _settings;
        public ConnectionFactory(SqlSettings settings) => settings = _settings;

        public string ConnectionString
        {
            get { return _settings.ConnectionString; }
        }

    }
}
