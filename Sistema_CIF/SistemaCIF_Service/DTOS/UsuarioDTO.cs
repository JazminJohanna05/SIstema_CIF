using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SistemaCIF_Service.DTOS
{
    [DataContract]
    public class UsuarioDTO
    {
        [DataMember]
        public string UsuarioId { get; set; }

        [DataMember]
        public string Nombre { get; set; }
        
        [DataMember]
        public string Apellido { get; set; }
        
        [DataMember]
        public string NombreUsuario { get; set; }
        
        [DataMember]
        public string Contraseña { get; set; }

        [DataMember]
        public string ConfirmacionContraseña { get; set; }

        [DataMember]
        public string Telefono { get; set; }

        [DataMember]
        public DateTime? FechaNacimiento { get; set; }

        [DataMember]
        public string Sexo { get; set; }
    }
}