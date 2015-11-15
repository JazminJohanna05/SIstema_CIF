using System;
using System.Collections.ObjectModel;
using System.Windows;
using GalaSoft.MvvmLight.Command;
using Sistema_CIF.Proxies.Usuario;

namespace Sistema_CIF.ViewModel
{
    class LoginViewModel : BaseViewModel
    {
        
        public LoginViewModel()
        {
            InicializarComandos();
            Registrarse = false;
            MostrarLogin = true;
        }

        #region Propiedades

        bool _registrarse;
        public bool Registrarse
        {
            get { return _registrarse; }
            set
            {
                if (_registrarse != value)
                {
                    _registrarse = value;
                    RaisePropertyChanged("Registrarse");
                }
            }
        }

        bool _mostrarLogin;
        public bool MostrarLogin
        {
            get { return _mostrarLogin; }
            set
            {
                if (_mostrarLogin != value)
                {
                    _mostrarLogin = value;
                    RaisePropertyChanged("MostrarLogin");
                }
            }
        }


        string _usuarioId;
        public string UsuarioId
        {
            get { return _usuarioId; }
            set
            {
                if (_usuarioId != value)
                {
                    _usuarioId = value;
                    RaisePropertyChanged("UsuarioId");
                }
            }
        }

        string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (_nombre != value)
                {
                    _nombre = value;
                    RaisePropertyChanged("Nombre");
                }
            }
        }

        string _apellido;
        public string Apellido
        {
            get { return _apellido; }
            set
            {
                if (_apellido != value)
                {
                    _apellido = value;
                    RaisePropertyChanged("Apellido");
                }
            }
        }

        string _nombreUsuario;
        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set
            {
                if (_nombreUsuario != value)
                {
                    _nombreUsuario = value;
                    RaisePropertyChanged("NombreUsuario");
                }
            }
        }

        string _contrasena;
        public string Contrasena
        {
            get { return _contrasena; }
            set
            {
                if (_contrasena != value)
                {
                    _contrasena = value;
                    RaisePropertyChanged("Contrasena");
                }
            }
        }

        string _confirmarContrasena;
        public string ConfirmarContrasena
        {
            get { return _confirmarContrasena; }
            set
            {
                if (_confirmarContrasena != value)
                {
                    _confirmarContrasena = value;
                    RaisePropertyChanged("ConfirmarContrasena");
                }
            }
        }

        string _telefono;
        public string Telefono
        {
            get { return _telefono; }
            set
            {
                if (_telefono != value)
                {
                    _telefono = value;
                    RaisePropertyChanged("Telefono");
                }
            }
        }

        DateTime _fechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set
            {
                if (_fechaNacimiento != value)
                {
                    _fechaNacimiento = value;
                    RaisePropertyChanged("FechaNacimiento");
                }
            }
        }

        string _sexo;
        public string Sexo
        {
            get { return _sexo; }
            set
            {
                if (_sexo != value)
                {
                    _sexo = value;
                    RaisePropertyChanged("Sexo");
                }
            }
        }


        ObservableCollection<UsuarioDTO> _listUsuario;
        public ObservableCollection<UsuarioDTO> ListUsuario
        {
            get { return _listUsuario; }
            set
            {
                if (_listUsuario != value)
                {
                    _listUsuario = value;
                    RaisePropertyChanged("ListUsuario");
                }
            }
        }

        ObservableCollection<UsuarioDTO> _listUsuarioOriginal;
        public ObservableCollection<UsuarioDTO> ListUsuarioOriginal
        {
            get { return _listUsuarioOriginal; }
            set
            {
                if (_listUsuarioOriginal != value)
                {
                    _listUsuarioOriginal = value;
                    RaisePropertyChanged("ListUsuarioOriginal");
                }
            }
        }
        #endregion

        #region Comandos
        public RelayCommand ComandoRegistrarUsuario { get; set; }
        public RelayCommand ComandoMostrarRegistrarUsuario { get; set; }

        public void InicializarComandos()
        {
            ComandoRegistrarUsuario = new RelayCommand(RegistrarUsuario);
            ComandoMostrarRegistrarUsuario = new RelayCommand(MostrarPantallaRegistro);
        }
        #endregion

        #region Metodos

        public void ObtenerDepartamento()
        {
            var proxiesUsuaio = new UsuarioServiceClient();
            var usuario = proxiesUsuaio.ObtenerUsuario();

            if (usuario!=null)
            {
                foreach (var item in usuario)
                {
                    var obtenerUsuario = new UsuarioDTO
                    {
                        UsuarioId = item.UsuarioId,
                        Nombre = item.Nombre,
                        Apellido = item.Apellido,
                        Contraseña = item.Contraseña,
                        ConfirmacionContraseña = item.ConfirmacionContraseña,
                        FechaNacimiento = item.FechaNacimiento,
                        Sexo = item.Sexo,
                        Telefono = item.Telefono
                    };
                    ListUsuario.Add(obtenerUsuario);
                    ListUsuarioOriginal.Add(obtenerUsuario);
                }
            }
            proxiesUsuaio.ObtenerUsuarioAsync();
        }

        public void RegistrarUsuario()
        {
            var proxiesUsurio = new UsuarioServiceClient();
            var addUsuario = new UsuarioDTO()
            {
                UsuarioId = UsuarioId,
                Nombre = Nombre,
                Apellido = Apellido,
                Contraseña = Contrasena,
                ConfirmacionContraseña = ConfirmarContrasena,
                Telefono = Telefono,
                FechaNacimiento = FechaNacimiento,
                Sexo = Sexo
            };
            proxiesUsurio.CrearUsuarioAsync(addUsuario);
            ListUsuario.Add(addUsuario);
            MostrarLogin = true;
            Registrarse = false ;
            MessageBox.Show("El Usuario ha sido Registrado");
        }

        public void MostrarPantallaRegistro()
        {
            Registrarse = true;
            MostrarLogin = false;
        }

        #endregion
    }
}
