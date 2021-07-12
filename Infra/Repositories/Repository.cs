using System;
using System.Collections.Generic;
using Dapper;
using teste01.Infra.Factories;

namespace teste01.Infra.Repositories
{
    public class Repository : IRepository
    {
        private readonly IDbFactory _dbFactory; 

        public Repository(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public IEnumerable<T> Query<T>(String sql, object param = null)
        {
            using(var cn = _dbFactory.GetConnection())
            {
                cn.Open();
                return cn.Query<T>(sql, param);
            }
        }

        public T QueryFirst<T>(String sql, object param = null)
        {        
            using(var cn = _dbFactory.GetConnection())
            {
                cn.Open();
                return cn.QueryFirst<T>(sql, param);
            }
        }

        public bool Execute(String sql, object param = null)
        {
            using(var cn = _dbFactory.GetConnection())
            {
                cn.Open();
                return (cn.Execute(sql, param) == 1);
            }
        }
    }
}
