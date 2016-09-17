using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using roasystemsPortal.domain.Entities.Catalog;

namespace roasystemsPortal.domain.Abstract.Catalog
{
    public interface IEstructuraOrganizacionalRepository
    {
        /// <summary>
        /// Get the list of EstructuraOrganizacional objects
        /// </summary>
        IEnumerable<EstructuraOrganizacional> EstructuraOrganizacional { get; }
    }
}
