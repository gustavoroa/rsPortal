//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace roasystemsPortal.domain.Concrete
//{
//    class EFDBContext
//    {
//    }
//}



//using iTandas.Domain.Entities.Business;
//using iTandas.Domain.Entities.Catalog;
//using iTandas.Domain.Entities.Seguridad;
using roasystemsPortal.domain.Entities.Security;
using roasystemsPortal.domain.Entities.Catalog;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roasystemsPortal.domain.Concrete
{
    public class EFDBContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<PermisoXUsuario> PermisosXUsuario { get; set; }
        public DbSet<PermisoXGrupo> PermisosXGrupo { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Aplicacion> Aplicaciones { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<EstructuraOrganizacional> EstructuraOrganizacional { get; set; }
        //public DbSet<PaymentSchedule> PaymentSchedules { get; set; }
        //public DbSet<ParticipantCollectionScheduledDate> ParticipantCollectionScheduledDates { get; set; }

    }
}