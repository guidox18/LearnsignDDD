using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Learnsign.Infraestructura.Contexto
{
    /// <summary>
    /// Clase Nos permite conectar con el gestor de base de datos 
    /// Importar "System.Data.Entity" para trabajar con DbContext 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class ContextoBase<TEntity>: DbContext where TEntity : DbContext
    {
        public ContextoBase(string as_conexion)
            : base(as_conexion)
        {
            Database.SetInitializer<TEntity>(null);
            Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
            //Configuration.ProxyCreationEnabled = false;
        }
    }
}
