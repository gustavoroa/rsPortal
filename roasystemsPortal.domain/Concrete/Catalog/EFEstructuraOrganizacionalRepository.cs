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
    public class EFEstructuraOrganizacionalRepository : IEstructuraOrganizacionalRepository
    {
        private readonly EFDBContext context = new EFDBContext();

        public IEnumerable<EstructuraOrganizacional> EstructuraOrganizacional
        {
            get { return context.EstructuraOrganizacional; }
        }
    }
}