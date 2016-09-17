using System;
using System.Security;
using RoaSystems.Data.Entities;

namespace RoaSystems.Data.Transactional.Entities
{
    /// <summary>
    /// Domain entity for the Aplicaciones table for use by a repository
    /// </summary>
    public class Aplicacion : EntityBase, ISaveable
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Url { get; set; }

    }
}
