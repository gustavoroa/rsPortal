using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using roasystemsPortal.domain.Entities;
using roasystemsPortal.domain.Entities.Catalog;

namespace roasystemsPortal.domain.Entities.Security
{
    public class Grupo : baseEntity
    {
        /// <summary>
        /// Gets or sets the company owner of this group.
        /// </summary>
        public Empresa Empresa { get; set; }

        /// <summary>
        /// Gets or sets the group name
        /// </summary>
        public string nombre { get; set; }

        /// <summary>
        /// Gets or sets a group description
        /// </summary>
        public string descripcion { get; set; }
    }
}
