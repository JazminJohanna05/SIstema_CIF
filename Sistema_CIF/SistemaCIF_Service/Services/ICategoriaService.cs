using SistemaCIF_Service.DTOS;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SistemaCIF_Service.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICategoriaService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICategoriaService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        ObservableCollection<CategoriaDTO> ObtenerCategoria();

        [OperationContract]
        void CrearCategoria(CategoriaDTO CategoriaDTO);

        [OperationContract]
        void RemoverCategoria(CategoriaDTO CategoriaDTO);

        [OperationContract]
        void EditarCategoria(CategoriaDTO CategoriaDTO);
    }
}
