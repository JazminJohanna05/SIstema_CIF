using SistemaCIF_Service.DTOS.ModuloComunesCIF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SistemaCIF_Service.Services.ModuloComunesCIF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IUsuarioService" en el código y en el archivo de configuración a la vez.
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
