using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Learnsign.Dominio.Repositorio
{
    public interface IRepositorioLectura<TEntity>
    {
        TEntity ObtenerPorCodigo(params object[] ao_llaves);
        IQueryable<TEntity> Listar();
        IList<TEntity> ObtenerPorExpresion(Expression<Func<TEntity, bool>> ao_llaves = null, string as_incluir = null, byte aby_limite = 0);
 
    }
}
