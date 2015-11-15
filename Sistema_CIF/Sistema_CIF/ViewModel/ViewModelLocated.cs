using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_CIF.ViewModel
{
    class ViewModelLocated
    {
        private ClienteViewModel _clienteViewModel;

        public ClienteViewModel ClienteViewModel
        {
            get
            {
                return _clienteViewModel ??
                    (_clienteViewModel = new ClienteViewModel());
            }
        }


        private CategoriaViewModel _categoriaViewModel;

        public CategoriaViewModel CategoriaViewModel
        {
            get
            {
                return _categoriaViewModel ??
                    (_categoriaViewModel = new CategoriaViewModel());
            }
        }


        private LoginViewModel _loginViewModel;

        public LoginViewModel LoginViewModel
        {
            get
            {
                return _loginViewModel ??
                    (_loginViewModel = new LoginViewModel());
            }
        }
    }
}
