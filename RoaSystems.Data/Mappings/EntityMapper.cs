using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DapperExtensions.Mapper;
using RoaSystems.Data.Entities;

namespace RoaSystems.Data.Mappings
{
    public class EntityMapper<T> : ClassMapper<T>, SqlMapper.ITypeMap where T : class, IEntity
    {
        public ConstructorInfo FindConstructor(string[] names, Type[] types)
        {
            return typeof(T).GetConstructor(Type.EmptyTypes);
        }

        public ConstructorInfo FindExplicitConstructor()
        {
            return null;
        }

        public SqlMapper.IMemberMap GetConstructorParameter(ConstructorInfo constructor, string columnName)
        {
            return null;
        }

        public SqlMapper.IMemberMap GetMember(string columnName)
        {
            if (Properties.Any(x => x.ColumnName == columnName))
            {
                return new MemberMap(
                    typeof(T).GetMember(Properties.First(x => x.ColumnName == columnName).Name).Single(),
                    columnName);
            }
            // reverse mapping lookup.
            // there seems to be an issue when Dapper Query<> is used along with DapperExtensions Get<> and GetList<>.
            if (Properties.Any(x => x.Name == columnName))
            {
                return new MemberMap(
                    typeof(T).GetMember(columnName).Single(),
                    Properties.First(x => x.Name == columnName).ColumnName);
            }

            return null;
        }
    }
}
