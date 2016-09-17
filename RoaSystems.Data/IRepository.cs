//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RoaSystems.Data
//{
//    interface IRepository
//    {
//    }
//}



using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq.Expressions;
using RoaSystems.Data.Entities;

namespace RoaSystems.Data
{
    public interface IRepository<T> : IDisposable where T : class, IEntity
    {
        IEnumerable<T> QuerySql(string sql, IEnumerable<MySqlParameter> sqlParams = null, int timeout = 30);

        IEnumerable<T> QueryProcedure(string spName, IEnumerable<MySqlParameter> sqlParams = null, int timeout = 30);

        T Get(object id);
        dynamic Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}