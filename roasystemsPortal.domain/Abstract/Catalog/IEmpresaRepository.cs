using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using roasystemsPortal.domain.Entities.Catalog;

namespace roasystemsPortal.domain.Abstract.Catalog
{
    public interface IEmpresaRepository
    {
        /// <summary>
        /// Get the list of Empresa objects
        /// </summary>
        IEnumerable<Empresa> Empresas { get; }
    }
}
