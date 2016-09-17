using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace RoaSystems.Data.Entities
{
    public abstract class EntityBase : IEntity
    {
        // the primary key
        public Int64 id { get; set; }
        public DateTime CREATION_DATE { get; set; }
        public Int64 CREATED_BY { get; set; }
        public Int64? LAST_UPDATED_BY { get; set; }
        public DateTime? LAST_UPDATE_DATE { get; set; }
        public bool? DELETED { get; set; }
        public Int64? DELETED_BY { get; set; }
        public DateTime? DELETED_DATE { get; set; }
    }
}


//namespace StevesBlinds.Data.Entities
//{
//    public abstract class EntityBase : IEntity
//    {
//        // the primary key
//        public int Id { get; set; }
//    }
//}
