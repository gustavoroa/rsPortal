using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using roasystemsPortal.domain.Entities;

namespace roasystemsPortal.domain.Entities.Security
{
    public class Modulo : baseEntity
    {
        /// <summary>
        /// Gets or sets the modules aplication
        /// </summary>
        public Aplicacion Aplicacion { get; set; }

        /// <summary>
        /// Gets or sets the module name
        /// </summary>
        public string nombre { get; set; }

        /// <summary>
        /// Gets or sets an module description
        /// </summary>
        public string descripcion { get; set; }
    }
}
