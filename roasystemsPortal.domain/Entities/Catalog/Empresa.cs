using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using roasystemsPortal.domain.Entities;

namespace roasystemsPortal.domain.Entities.Catalog
{
    public class Empresa : baseEntity
    {
        public Empresa Company { get; set; }

        /// <summary>
        /// Gets or sets the company name
        /// </summary>
        public string nombre { get; set; }

        /// <summary>
        /// Gets or sets a company description
        /// </summary>
        public string descripcion { get; set; }

        /// <summary>
        /// Gets or sets the company RFC (Mexico)
        /// </summary>
        public string rfc { get; set; }

        /// <summary>
        /// Gets or sets the company Address
        /// </summary>
        public string domFiscal { get; set; }
    }
}
