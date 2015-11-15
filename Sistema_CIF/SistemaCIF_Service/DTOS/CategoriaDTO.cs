using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SistemaCIF_Service.DTOS
{
    [DataContract]
    public class CategoriaDTO
    {
        [DataMember]
        public string CategoriaId { get; set; }

        [DataMember]
        public string Descripcion { get; set; }
    }
}