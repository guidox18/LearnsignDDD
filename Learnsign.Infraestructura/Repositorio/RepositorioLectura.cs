using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learnsign.Dominio.Repositorio;
using System.Data.Entity;
using Learnsign.Infraestructura.Contexto;

namespace Learnsign.Infraestructura.Repositorio
{
    public class RepositorioLectura<TEntity> :IRepositorioLectura<TEntity> where TEntity: class
    {
        public IDbSet<TEntity> Entidad { get; set; }
        public RepositorioLectura(LSContexto ao_contexto)
        {
            this.Entidad = ao_contexto.Set<TEntity>();
        }
        public RepositorioLectura()
            : this(new LSContexto("name=CONEXIONSQL"))
        {
            //this.Entidad = System.Reflection.Assembly.GetAssembly(typeof(C)).CreateInstance(typeof(C));
        }
        public TEntity ObtenerPorCodigo(params object[] ao_llaves)
        {
            return Entidad.Find(ao_llaves);
        }

       
        public IQueryable<TEntity> Listar()
        {
            return Entidad;
        }
    }
}
