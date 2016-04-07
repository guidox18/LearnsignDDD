using HRSolucion.Datos.EF.Mapeos;
using HRSolucion.Dominio.Entidades;
using System;
using System.Data.Entity;


namespace HRSolucion.Datos.EF.Contextos
{
    public class HRContexto : DbContext //ContextoBase<HRContexto>
    {
        public HRContexto(string as_conexion)
            : base(as_conexion)
        {
            //Database.SetInitializer<HRContexto>(null);
            Database.SetInitializer<HRContexto>(new InicializadorBD());
        }
        public HRContexto()
            : base("HRcnx")
        {
        }

        public DbSet<Region> Regiones { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Locacion> Locaciones { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new RegionConfiguracion());
            modelBuilder.Configurations.Add(new PaisConfiguracion());
            modelBuilder.Configurations.Add(new LocacionConfiguracion());
            modelBuilder.Configurations.Add(new DepartamentoConfiguracion());
            modelBuilder.Configurations.Add(new CargoConfiguracion());
            modelBuilder.Configurations.Add(new EmpleadoConfiguracion());
        }

        public void Dispose()
        {
            base.Dispose();
        }
    }
}
