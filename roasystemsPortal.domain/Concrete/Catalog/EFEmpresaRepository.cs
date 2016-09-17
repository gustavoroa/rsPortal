using roasystemsPortal.domain.Entities.Catalog;
using roasystemsPortal.domain.Abstract.Catalog;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roasystemsPortal.domain.Concrete.Catalog
{
    public class EFEmpresaRepository : IEmpresaRepository
    {
        private readonly EFDBContext context = new EFDBContext();

        public IEnumerable<Empresa> Empresas
        {
            get { return context.Empresas; }
        }
    }
}