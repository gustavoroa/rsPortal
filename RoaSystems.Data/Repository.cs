using System;
using System.Collections.Generic;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Linq.Expressions;
using Dapper;
using DapperExtensions;
using RoaSystems.Data.Entities;

namespace RoaSystems.Data
{
    public abstract class Repository<T> : IRepository<T>
        where T : class, IEntity
    {
        protected Repository(IDataContext context)
        {
            Context = context;
        }

        protected IDataContext Context { get; private set; }


        // Custom SQL

        public IEnumerable<T> QuerySql(string sql, IEnumerable<MySqlParameter> sqlParams = null, int timeout = 30)
        {
            return Query(sql, Transform(sqlParams), timeout, CommandType.Text);
        }

        // Stored procedure

        public IEnumerable<T> QueryProcedure(string spName, IEnumerable<MySqlParameter> sqlParams = null, int timeout = 30)
        {
            return Query(spName, Transform(sqlParams), timeout, CommandType.StoredProcedure);
        }


        private IEnumerable<T> Query(string sql, SqlMapper.IDynamicParameters dynamicParameters, int timeout, CommandType commandType)
        {
            Context.Open();
            return Context.Connection.Query<T>(sql, dynamicParameters, null, true, timeout, commandType);
        }


        // Parameter transformations

        private static DynamicParameters Transform(IEnumerable<MySqlParameter> sqlParams)
        {
            if (sqlParams == null)
                return null;

            var parameters = new DynamicParameters();
            sqlParams.ToList().ForEach(p => parameters.Add(p.ParameterName, p.Value)); //, p.DbType, p.Direction, p.Size));
            return parameters;
        }

        // todo - implement support for passing filter conditions via an anonymous object.
        //private static DynamicParameters Transform(object anonymousParams)
        //{
        //    if (anonymousParams == null)
        //        return null;

        //    var parameters = new DynamicParameters();
        //    anonymousParams.GetType().GetProperties().ToList()
        //        .ForEach(p => parameters.Add("@" + p.Name, p.GetValue(anonymousParams)));
        //    return parameters;
        //}



        public T Get(object id)
        {
            Context.Open();
            return Context.Connection.Get<T>(id);
        }

        // Entity management operations

        public virtual dynamic Insert(T entity)
        {
            if (!(entity is ISaveable))
                throw new ArgumentException("Entity type must saveable for CRUD oeprations.", "entity");

            Context.Open();
            return Context.Connection.Insert(entity);
        }

        public virtual bool Update(T entity)
        {
            if (!(entity is ISaveable))
                throw new ArgumentException("Entity type must saveable for CRUD oeprations.", "entity");

            Context.Open();
            return Context.Connection.Update(entity);
        }

        public virtual bool Delete(T entity)
        {
            if (!(entity is ISaveable))
                throw new ArgumentException("Entity type must saveable for CRUD oeprations.", "entity");

            Context.Open();
            return Context.Connection.Delete(entity);
        }

        public void Dispose()
        {
            if (Context != null)
                Context.Dispose();
        }
    }
}
