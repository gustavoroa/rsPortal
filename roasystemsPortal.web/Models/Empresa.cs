//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace roasystemsPortal.web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empresa
    {
        public long id { get; set; }
        public Nullable<long> padreId { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string rfc { get; set; }
        public string domFiscal { get; set; }
        public long CREATED_BY { get; set; }
        public System.DateTime CREATION_DATE { get; set; }
        public Nullable<long> LAST_UPDATED_BY { get; set; }
        public Nullable<System.DateTime> LAST_UPDATE_DATE { get; set; }
        public bool DELETED { get; set; }
        public Nullable<long> DELETED_BY { get; set; }
        public Nullable<System.DateTime> DELETED_DATE { get; set; }
    }
}