using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learnsign.Dominio;

namespace Learnsign.Dominio.Repositorio
{
    /// <summary>
    /// Clase Interfaz que nos permita 
    /// </summary>
    public interface IRepository<TEntity> : IRepositorioLectura<TEntity>
    {
        bool Adicionar(TEntity ao_entidad);
        bool Actualizar(TEntity ao_entidad);
        bool GuardarCambios();
    }
}
