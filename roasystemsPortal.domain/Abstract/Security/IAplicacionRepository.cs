using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using roasystemsPortal.domain.Entities.Security;

namespace roasystemsPortal.domain.Abstract.Security
{
    public interface IAplicacionRepository
    {
        /// <summary>
        /// Get the list of Application objects
        /// </summary>
        IEnumerable<Aplicacion> Aplicaciones { get; }
    }
}
