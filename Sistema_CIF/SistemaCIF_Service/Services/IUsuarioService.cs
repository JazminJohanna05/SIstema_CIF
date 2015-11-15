using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SistemaCIF_Service.DTOS;

namespace SistemaCIF_Service.Services
{
    [ServiceContract]
    public interface IUsuarioService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        ObservableCollection<UsuarioDTO> ObtenerUsuario();

        [OperationContract]
        void CrearUsuario(UsuarioDTO usuarioDto);

        [OperationContract]
        void RemoverUsuarioo(UsuarioDTO usuarioDto);

        [OperationContract]
        void EditarUsuario(UsuarioDTO usuarioDto);
    }
}
