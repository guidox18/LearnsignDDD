using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSign.Dominio.InterfazRepo
{
    public interface IRepositorioLectura
    {
        IQueryable<TEntity> Get();
        void Add(TEntity obj);
    }
}
