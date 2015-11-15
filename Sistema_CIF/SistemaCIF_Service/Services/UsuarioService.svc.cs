using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SistemaCIF_Service.DTOS;
using SistemaCIF_Service.Model;

namespace SistemaCIF_Service.Services
{
    public class UsuarioService : IUsuarioService
    {
        public void DoWork()
        {
        }

        public ObservableCollection<UsuarioDTO> ObtenerUsuario()
        {
            using (var contexto = new Sistema_CIFEntities())
            {
                var usuario = new ObservableCollection<UsuarioDTO>();

                foreach (var item in contexto.Usuario)
                {
                    usuario.Add(new UsuarioDTO()
                    {
                        UsuarioId = item.UsuarioId,
                        Nombre = item.Nombre,
                        Apellido = item.Apellido,
                        Contraseña = item.Contrasena,
                        ConfirmacionContraseña = item.ConfirmacionContrasena,
                        FechaNacimiento = item.FechaNacimiento,
                        NombreUsuario = item.NombreUsuario,
                        Sexo = item.Sexo,
                        Telefono = item.Telefono
                    });
                }
                return usuario;
            }
        }

        public void CrearUsuario(UsuarioDTO usuarioDto)
        {
            using (var contexto = new Sistema_CIFEntities())
            {
                var usuarioExiste = contexto.Usuario.FirstOrDefault(t => t.UsuarioId == usuarioDto.UsuarioId);

                if (usuarioExiste == null)
                {
                    contexto.Usuario.Add(new Usuario()
                    {
                        UsuarioId = usuarioDto.UsuarioId,
                        Nombre = usuarioDto.Nombre,
                        Apellido = usuarioDto.Apellido,
                        Contrasena = usuarioDto.Contraseña,
                        ConfirmacionContrasena = usuarioDto.ConfirmacionContraseña,
                        FechaNacimiento = usuarioDto.FechaNacimiento,
                        NombreUsuario = usuarioDto.NombreUsuario,
                        Sexo = usuarioDto.Sexo,
                        Telefono = usuarioDto.Telefono

                    });
                    contexto.SaveChanges();
                }
            }
        }

        public void RemoverUsuarioo(UsuarioDTO usuarioDto)
        {
            using (var contexto = new Sistema_CIFEntities())
            {
                var usuarioExiste = contexto.Usuario.FirstOrDefault(t => t.UsuarioId == usuarioDto.UsuarioId);
                if (usuarioExiste != null)
                {
                    contexto.Usuario.Remove(usuarioExiste);
                }
                contexto.SaveChanges();
            }
        }

        public void EditarUsuario(UsuarioDTO usuarioDto)
        {
            using (var contexto = new Sistema_CIFEntities())
            {
                var usuarioExiste = contexto.Usuario.FirstOrDefault(t => t.UsuarioId == usuarioDto.UsuarioId);

                if (usuarioExiste != null)
                {
                    usuarioExiste.UsuarioId = usuarioDto.UsuarioId;
                    usuarioExiste.Nombre = usuarioDto.Nombre;
                    usuarioExiste.Apellido = usuarioDto.Apellido;
                    usuarioExiste.Contrasena = usuarioDto.Contraseña;
                    usuarioExiste.ConfirmacionContrasena = usuarioDto.ConfirmacionContraseña;
                    usuarioExiste.FechaNacimiento = usuarioDto.FechaNacimiento;
                    usuarioExiste.NombreUsuario = usuarioDto.NombreUsuario;
                    usuarioExiste.Sexo = usuarioDto.Sexo;
                    usuarioExiste.Telefono = usuarioDto.Telefono;
                }
                contexto.SaveChanges();
            }
        }
    }
}
