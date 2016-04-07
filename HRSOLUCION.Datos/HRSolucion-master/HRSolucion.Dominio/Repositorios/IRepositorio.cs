using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSolucion.Dominio.Repositorios
{
    public interface IRepositorio<T> : IRepositorioLectura<T>
    {
        bool Adicionar(T ao_entidad);
        bool Actualizar(T ao_entidad);
        bool GuardarCambios();
    }
}
