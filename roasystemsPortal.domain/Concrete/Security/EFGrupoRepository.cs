using roasystemsPortal.domain.Entities.Security;
using roasystemsPortal.domain.Abstract.Security;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roasystemsPortal.domain.Concrete.Seguridad
{
    public class EFGrupoRepository : IGrupoRepository
    {
        private readonly EFDBContext context = new EFDBContext();

        public IEnumerable<Grupo> Grupos
        {
            get { return context.Grupos; }
        }
    }
}