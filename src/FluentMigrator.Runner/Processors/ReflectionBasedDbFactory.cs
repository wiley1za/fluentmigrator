//namespace FluentMigrator.Runner.Processors
//{
//    using System;
//    using System.Data.Common;

//    public class ReflectionBasedDbFactory : DbFactoryBase
//    {
//        private readonly string assemblyName;
//        private readonly string dbProviderFactoryTypeName;

//        public ReflectionBasedDbFactory(string assemblyName, string dbProviderFactoryTypeName)
//        {
//            this.assemblyName = assemblyName;
//            this.dbProviderFactoryTypeName = dbProviderFactoryTypeName;
//        }

//        protected override DbProviderFactory CreateFactory()
//        {
//            return new DbProviderFactory();
//            return (DbProviderFactory)AppDomain.CurrentDomain.CreateInstanceAndUnwrap(assemblyName, dbProviderFactoryTypeName);
//        }
//    }
//}