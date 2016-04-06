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
    public interface IRepository<TEntity> where TEntity : Alumno
    {
        void Add(TEntity obj);
        void AddAll(IEnumerable<TEntity> obj);
        void DeleteAll(IEnumerable<TEntity> obj);
        void Delete(TEntity obj);
        void Delete(int id);
        TEntity Get(int id);
        TEntity First();
        IQueryable<TEntity> Get();
        void Update(TEntity obj);
        void Commit();
        void AddOrUpdate(TEntity obj);
    }
}
