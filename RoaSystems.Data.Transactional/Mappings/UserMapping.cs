using DapperExtensions.Mapper;
using RoaSystems.Data.Mappings;
using RoaSystems.Data.Transactional.Entities;

namespace RoaSystems.Data.Transactional.Mappings
{
    /// <summary>
    /// Mapping entity properties to database columns
    /// </summary>
    public sealed class UserMapping : EntityMapper<User>
    {
        public UserMapping()
        {
            Table("Users");

            Map(x => x.id).Column("UserId").Key(KeyType.Identity);

            // only map properties that don't match column names; otherwise AutoMap()
            Map(x => x.FirstName).Column("UserFirstName");
            Map(x => x.LastName).Column("UserLastName");

            // map all other columns where properties match column names
            AutoMap();
        }
    }
}