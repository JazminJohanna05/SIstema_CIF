using GalaSoft.MvvmLight.Command;
using Sistema_CIF.Proxies.Categoria;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sistema_CIF.ViewModel
{
    class CategoriaViewModel: BaseViewModel
    {
        public CategoriaViewModel()
        {
            InicializarComandos();
            ListCategoria = new ObservableCollection<CategoriaDTO>();
            ListCategoriaOriginal = new ObservableCollection<CategoriaDTO>();
        }

        #region Propiedades




        string _CategoriaId;
        public string CategoriaId
        {
            get { return _CategoriaId; }
            set
            {
                if (_CategoriaId != value)
                {
                    _CategoriaId = value;
                    RaisePropertyChanged("CategoriaId");
                }
            }
        }

        string _descripcion;
        public string Descripcion
        {
            get { return _descripcion; }
            set
            {
                if (_descripcion != value)
                {
                    _descripcion = value;
                    RaisePropertyChanged("Descripcion");
                }
            }
        }

       

        ObservableCollection<CategoriaDTO> _listCategoria;
        public ObservableCollection<CategoriaDTO> ListCategoria
        {
            get { return _listCategoria; }
            set
            {
                if (_listCategoria != value)
                {
                    _listCategoria = value;
                    RaisePropertyChanged("ListCategoria");
                }
            }
        }

        ObservableCollection<CategoriaDTO> _listCategoriaOriginal;
        public ObservableCollection<CategoriaDTO> ListCategoriaOriginal
        {
            get { return _listCategoriaOriginal; }
            set
            {
                if (_listCategoriaOriginal != value)
                {
                    _listCategoriaOriginal = value;
                    RaisePropertyChanged("ListCategoriaOriginal");
                }
            }
        }
        #endregion

        #region Comandos
        public RelayCommand ComandoRegistrarCategoria{ get; set; }
        public RelayCommand ComandoMostrarEditar { get; set; }
         public RelayCommand ComandoMostrarEliminar { get; set; }

        public void InicializarComandos()
        {
            ComandoRegistrarCategoria = new RelayCommand(RegistrarCategoria);
            ComandoMostrarEditar = new RelayCommand(EditarCategoria);
            ComandoMostrarEliminar = new RelayCommand(EliminarCategoria);
           
        }

        private void EditarCategoria()
        {
            throw new NotImplementedException();
        }

        private void EliminarCategoria()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Metodos

        public void ObtenerCqategoria()
        {
            var proxiesCategoria = new CategoriaServiceClient();
            var Categoria = proxiesCategoria.ObtenerCategoria();

            if (Categoria!=null)
            {
                foreach (var item in Categoria)
                {
                    var obtenerCategoria = new CategoriaDTO
                    {
                        CategoriaId = item.CategoriaId,
                        Descripcion = item.Descripcion
                     
                    };
                    ListCategoria.Add(obtenerCategoria);
                    ListCategoriaOriginal.Add(obtenerCategoria);
                }
            }
            proxiesCategoria.ObtenerCategoriaAsync();
        }

        public void RegistrarCategoria()
        {
            var proxiesCategoria = new CategoriaServiceClient();
            var addCategoria = new CategoriaDTO()
            {
                CategoriaId = CategoriaId,
                Descripcion = Descripcion
               
            };
            proxiesCategoria.CrearCategoriaAsync(addCategoria);
            ListCategoria.Add(addCategoria);
            MessageBox.Show("La Categoria ha sido Registrado");
        }



        #endregion
    }
}
