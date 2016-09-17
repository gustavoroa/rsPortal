using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using roasystemsPortal.domain.Entities;

namespace roasystemsPortal.domain.Entities.Security
{
    public class PermisoXGrupo : Permiso
    {
        /// <summary>
        /// Gets or sets an application description
        /// </summary>
        public Grupo Grupo { get; set; }
    }
}
