using Microsoft.AspNetCore.Builder;
using teste01.Infra.Factories;
using teste01.Infra.Extensions;

namespace teste01.Infra.Builders
{
    public static class DbInitializerBuilder
    {
        public static IApplicationBuilder InitializerDb(this IApplicationBuilder app)
        {
            var serviceProvider = app.ApplicationServices;
            var dbFactory = (DbFactory)serviceProvider.GetService(typeof(IDbFactory));

            using(var cn = dbFactory.GetConnection())
            {
                cn.Open();
                cn.InitializerDb();        
            }
            return app;
        }
    }
}
