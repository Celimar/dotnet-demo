using System;
using System.Data.Common;
using Dapper;

namespace teste01.Infra.Extensions
{
    public static class DbInitializerExt
    {
        public static void InitializerDb(this DbConnection obj)
        {
            var sql = @"
                CREATE TABLE IF NOT EXISTS ferramenta (
                    id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                    nome TEXT NOT NULL
                );
            ";
            obj.Execute(sql); 
        }
    }
}
