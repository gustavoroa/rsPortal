using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using roasystemsPortal.domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace roasystemsPortal.domain.Entities.Security
{
    public class Usuario : baseEntity
    {
        ///// <summary>
        ///// Gets or sets the application name
        ///// </summary>
        //public string nombre { get; set; }

        ///// <summary>
        ///// Gets or sets an application description
        ///// </summary>
        //public string descripcion { get; set; }

        ///// <summary>
        ///// Gets or sets the URL or directory where the application is located
        ///// </summary>
        //public string url { get; set; }


        /// <summary>
        /// Gets or sets the user login name
        /// </summary>
        [Required]
        [Display(Name = "user_loginName_label", ResourceType = typeof(object))]
        public string loginName { get; set; }

        /// <summary>
        /// Gets or sets the password
        /// </summary>
        [Required]
        [Display(Name = "Login name")]
        //[P]
        public byte[] contrasenia { get; set; }


        public byte[] firma { get; set; }
        public string apPaterno { get; set; }
        public string apMaterno { get; set; }
        public string nombres { get; set; }

        /// <summary>
        /// Gets or sets the user email
        /// </summary>
        [Required]
        [Display(Name = "Email:")]
        [EmailAddress]
        public string eMail { get; set; }
        public string tweeter { get; set; }
        public string facebook { get; set; }

        [Display(Name = "Login name")]
        [Phone]
        public string telefono { get; set; }

        [Required]
        [Display(Name = "Celular")]
        [Phone]
        public string celular { get; set; }
        public string culture { get; set; }
        public bool requiereCambiarPassword { get; set; }
        public bool requiereCambiarFirma { get; set; }
        public bool esAdmin { get; set; }
        public Nullable<int> diasDuracionContrasenia { get; set; }
        public Nullable<int> diasDuracionFirma { get; set; }
        public Nullable<bool> recibirNotificaciones { get; set; }
        public Nullable<bool> aceptaTerminosDeServicio { get; set; }
        public bool confirmed { get; set; }
        public Nullable<System.DateTime> CONFIRMATION_DATE { get; set; }

    }
}
