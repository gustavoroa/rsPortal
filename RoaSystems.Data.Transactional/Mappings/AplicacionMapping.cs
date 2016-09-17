using DapperExtensions.Mapper;
using RoaSystems.Data.Mappings;
using RoaSystems.Data.Transactional.Entities;

namespace RoaSystems.Data.Transactional.Mappings
{
    /// <summary>
    /// Mapping entity properties to database columns
    /// </summary>
    public sealed class AplicacionMapping : EntityMapper<Aplicacion>
    {
        public AplicacionMapping()
        {
            Table("Aplicaciones");

            Map(x => x.id).Column("id").Key(KeyType.Identity);

            // only map properties that don't match column names; otherwise AutoMap()
            Map(x => x.Nombre).Column("nombre");
            Map(x => x.Descripcion).Column("descripcion");
            Map(x => x.Url).Column("url");
            // map all other columns where properties match column names
            //AutoMap();
        }
    }
}