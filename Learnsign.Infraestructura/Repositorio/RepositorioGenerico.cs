using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learnsign.Dominio.Repositorio;
using Learnsign.Infraestructura.Contexto;
using System.Data.Entity;

namespace Learnsign.Infraestructura.Repositorio
{
    public class RepositorioGenerico<TEntity> : IRepository<TEntity> where TEntity : class
    {
        LSContexto io_contexto;
        public IDbSet<TEntity> Entidad { get; set; }
        public RepositorioGenerico(LSContexto ao_contexto)
        {
            this.io_contexto = ao_contexto;
            this.Entidad = ao_contexto.Set<TEntity>();
        }


        public RepositorioGenerico()
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

 
        public bool Adicionar(TEntity ao_entidad)
        {
            Entidad.Add(ao_entidad);
            return true;
        }

        public bool Actualizar(TEntity ao_entidad)
        {
            throw new NotImplementedException();
        }

        public bool GuardarCambios()
        {
            io_contexto.SaveChanges();
            return true;
        }

    }
}
