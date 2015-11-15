using SistemaCIF_Service.DTOS;
using SistemaCIF_Service.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SistemaCIF_Service.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CategoriaService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CategoriaService.svc o CategoriaService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CategoriaService : ICategoriaService
    {
        public void DoWork()
        {
        }





        public ObservableCollection<CategoriaDTO> ObtenerCategoria()
        {
            using (var contexto = new Sistema_CIFEntities())
            {
                var Categoria = new ObservableCollection<CategoriaDTO>();

                foreach (var item in contexto.Categoria)
                {
                    Categoria.Add(new CategoriaDTO()
                    {
                        CategoriaId = item.CategoriaId,
                        Descripcion = item.Descripcion                       
                    });
                }
                return Categoria;
            }
        }

        public void CrearCategoria(CategoriaDTO CategoriaDTO)
        {
            using (var contexto = new Sistema_CIFEntities())
            {
                var CategoriaExiste = contexto.Categoria.FirstOrDefault(t => t.CategoriaId == CategoriaDTO.CategoriaId);

                if (CategoriaExiste == null)
                {
                    contexto.Categoria.Add(new Categoria()
                    {
                        CategoriaId = CategoriaDTO.CategoriaId,
                        Descripcion = CategoriaDTO.Descripcion,
                    });
                    contexto.SaveChanges();
                }
            }
        }

        public void RemoverCategoria(CategoriaDTO CategoriaDTO)
        {
            using (var contexto = new Sistema_CIFEntities())
            {
                var CategoriaExiste = contexto.Categoria.FirstOrDefault(t => t.CategoriaId == CategoriaDTO.CategoriaId);
                if (CategoriaExiste != null)
                {
                    contexto.Categoria.Remove(CategoriaExiste);
                }
                contexto.SaveChanges();
            }
        }

        public void EditarCategoria(CategoriaDTO CategoriaDTO)
        {
            using (var contexto = new Sistema_CIFEntities())
            {
                var CategoriaExiste = contexto.Categoria.FirstOrDefault(t => t.CategoriaId == CategoriaDTO.CategoriaId);

                if (CategoriaExiste != null)
                {
                    CategoriaExiste.CategoriaId = CategoriaDTO.CategoriaId;
                    CategoriaExiste.Descripcion = CategoriaDTO.Descripcion;
                }
                contexto.SaveChanges();
            }
        }
    }
}
