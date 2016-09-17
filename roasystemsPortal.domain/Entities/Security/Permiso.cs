using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using roasystemsPortal.domain.Entities;
using roasystemsPortal.domain.Entities.Catalog;

namespace roasystemsPortal.domain.Entities.Security
{ 
    /// <summary>
    /// Permisions base class
    /// </summary>
    public class Permiso : baseEntity
    {
        /// <summary>
        /// Gets or sets the Application Module for the permission object
        /// </summary>
        public Modulo Modulo { get; set; }

        /// <summary>
        /// Gets or sets the Enterprise object for the permission
        /// </summary>
        public Empresa Empresa { get; set; }

        /// <summary>
        /// Gets or sets the value which indicates if the user can list the data or have access to the module
        /// </summary>
        public bool pSELECT { get; set; }

        /// <summary>
        /// gets or sets the value which indicates if the user has permission for insert data in the module
        /// </summary>
        public bool pINSERT { get; set; }

        /// <summary>
        /// Gets or sets the value which indicates if the user has the permission for update data in the module
        /// </summary>
        public bool pUPDATE { get; set; }

        /// <summary>
        /// Gets or sets the value which indicates if the user has the permission for logic deleting data in the module
        /// </summary>
        public bool pDELETE { get; set; }

        /// <summary>
        /// Gets or sets the value which indicates if the user has the permission for recovering deleted data in the module
        /// </summary>
        public bool pUNDELETE { get; set; }

        /// <summary>
        /// Gets or sets the permission which indicates if the user has permission to perform physical data deleting in the module
        /// </summary>
        public bool pKILL { get; set; }

        /// <summary>
        /// Gets or sets the permission which indicates if the user can get access to the module reports
        /// </summary>
        public bool pREPORT { get; set; }

        /// <summary>
        /// Gets or sets the permission which indicates if the user can print info presented in the module.
        /// </summary>
        public bool pPRINT { get; set; }

        /// <summary>
        /// Gets or sets the permission which indicates if the user can download files from the current module.
        /// </summary>
        public bool pDOWNLOAD { get; set; }

        /// <summary>
        /// Gets or sets the permission which indicates if the user can upload files to the current module.
        /// </summary>
        public bool pUPLOAD { get; set; }


    }
}
