using System.Data;
using System.Data.SqlServerCe;

namespace FluentMigrator.Runner.Processors
{
    public class DbProviderFactory
    {
        public IDbConnection CreateConnection()
        {
            return new SqlCeConnection();
        }

        public IDbDataAdapter CreateDataAdapter()
        {
            return new SqlCeDataAdapter();
        }
    }
}