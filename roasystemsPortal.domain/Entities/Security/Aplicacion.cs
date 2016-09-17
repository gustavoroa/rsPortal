using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using roasystemsPortal.domain.Entities;

namespace roasystemsPortal.domain.Entities.Security
{
    public class Aplicacion : baseEntity
    {
        /// <summary>
        /// Gets or sets the application name
        /// </summary>
        public string nombre { get; set; }

        /// <summary>
        /// Gets or sets an application description
        /// </summary>
        public string descripcion { get; set; }

        /// <summary>
        /// Gets or sets the URL or directory where the application is located
        /// </summary>
        public string url { get; set; }
    }
}
