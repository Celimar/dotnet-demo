using System;
using System.Collections.Generic;

namespace teste01.Infra.Repositories
{
    public interface IRepository
    {
        IEnumerable<T> Query<T>(String sql, object param = null);
        T QueryFirst<T>(String sql, object param = null);
        bool Execute(String sql, object param = null);
    }
}