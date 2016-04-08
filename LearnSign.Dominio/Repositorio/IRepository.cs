using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnSign.Dominio;

namespace LearnSign.Dominio.InterfazRepo
{
    /// <summary>
    /// Clase Interfaz que nos permita 
    /// </summary>
    public interface IRepository<TEntity> : IRepositorioLectura
    {
        void Agregar(TEntity obj);
        void Eliminar(TEntity obj);
        void Eliminar(int id);
        TEntity Obtener(int id);
        TEntity First();
        IQueryable<TEntity> Get();
        void Update(TEntity obj);
        void Commit();
        void AddOrUpdate(TEntity obj);
    }
}
