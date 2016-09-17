using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using roasystemsPortal.domain.Entities;

namespace roasystemsPortal.domain.Entities.Catalog
{
    public class EstructuraOrganizacional : baseEntity
    {
        /// <summary>
        /// Gets or sets the company owner of this organizational structure
        /// </summary>
        public Empresa Company { get; set; }

        /// <summary>
        /// Gets or sets the parent item of this organizational structure item
        /// </summary>
        public EstructuraOrganizacional Padre { get; set; }

        /// <summary>
        /// Gets or sets the organizational structure name
        /// </summary>
        public string nombre { get; set; }

        /// <summary>
        /// Gets or sets a organizational structure description
        /// </summary>
        public string descripcion { get; set; }

        /// <summary>
        /// Gets or sets the objetive of this orgabizational structure item
        /// </summary>
        public string objetivo { get; set; }

        /// <summary>
        /// Gets or sets the vision for this organizational structure item
        /// </summary>
        public string mision { get; set; }

        /// <summary>
        /// Gets or sets the vision for this organizational structure item
        /// </summary>
        public string vision { get; set; }

        /// <summary>
        /// Gets or sets the values for this organizational structure item
        /// </summary>
        public string valores { get; set; }
    }
}
