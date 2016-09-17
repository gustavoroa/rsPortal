using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace RoaSystems.Data.Mappings
{
    public class MemberMap : SqlMapper.IMemberMap
    {
        private readonly MemberInfo _member;
        private readonly string _columnName;

        public MemberMap(MemberInfo member, string columnName)
        {
            _member = member;
            _columnName = columnName;
        }

        public string ColumnName
        {
            get { return _columnName; }
        }

        public FieldInfo Field
        {
            get { return _member as FieldInfo; }
        }

        public Type MemberType
        {
            get
            {
                switch (_member.MemberType)
                {
                    case MemberTypes.Field:
                        return ((FieldInfo)_member).FieldType;
                    case MemberTypes.Property:
                        return ((PropertyInfo)_member).PropertyType;
                    default:
                        throw new NotSupportedException();
                }
            }
        }

        public ParameterInfo Parameter
        {
            get { return null; }
        }

        public PropertyInfo Property
        {
            get { return _member as PropertyInfo; }
        }
    }
}
