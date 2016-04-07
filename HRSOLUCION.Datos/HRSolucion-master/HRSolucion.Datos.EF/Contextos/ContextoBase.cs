using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HRSolucion.Datos.EF.Contextos
{
    public class ContextoBase<T> : DbContext where T : DbContext
    {
        public ContextoBase(string as_conexion)
            : base(as_conexion)
        {
            Database.SetInitializer<T>(null);
            Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
            //Configuration.ProxyCreationEnabled = false;
        }
    }
}
/*
 * Open command prompt
Run SqlLocalDB.exe start v11.0
Run SqlLocalDB.exe info v11.0
Copy the Instance pipe name that starts with np:\...
In Visual Studio select TOOLS > Connect to Database...
For Server Name enter (localdb)\v11.0. If it didn't work, use the Instance pipe name that you copied earlier. You can also use this to connect with SQL Management Studio.
Select the database on next dropdown list
Click OK
*/