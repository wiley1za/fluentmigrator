namespace FluentMigrator.Runner.Processors.SqlServer
{
    public class SqlServerCeDbFactory : DbFactoryBase
    {

        protected override DbProviderFactory CreateFactory()
        {
            
            return new SqlCeProviderFactory();
        }
    }

    public class SqlCeProviderFactory : DbProviderFactory
    {
    }
}