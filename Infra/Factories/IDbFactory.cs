using System.Data.Common;

namespace teste01.Infra.Factories
{
    public interface IDbFactory
    {
        DbConnection GetConnection();
    }
}