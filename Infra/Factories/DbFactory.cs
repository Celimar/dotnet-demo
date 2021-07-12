using System;
using System.Data.Common;
using System.Data.SQLite;

namespace teste01.Infra.Factories
{
    public class DbFactory: IDbFactory
    {
        public DbConnection GetConnection()
        {
            return new SQLiteConnection("Data Source=demodb.db");
        }
    }
}
