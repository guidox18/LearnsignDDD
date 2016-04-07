using HRSolucion.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace HRSolucion.Datos.EF.Mapeos
{
    public class DepartamentoConfiguracion : EntityTypeConfiguration<Departamento>
    {
        public DepartamentoConfiguracion()
        {
            ToTable("DEPARTMENTS", "HR");
            HasKey(k => k.IDDepartamento);
            Property(p => p.IDDepartamento).HasColumnName("DEPARTMENT_ID").IsRequired();
            Property(p => p.NombreDepartamento).HasColumnName("DEPARTMENT_NAME").IsRequired();
            Property(p => p.IDAdministrador).HasColumnName("MANAGER_ID");
            Property(p => p.IDLocacion).HasColumnName("LOCATION_ID");
            HasOptional(m => m.Locacion).WithMany().HasForeignKey(m => m.IDLocacion);
        }
    }
}

//Table DEPARTMENTS
// Name                                      Null?    Type
// ----------------------------------------- -------- ----------------------------
// DEPARTMENT_ID                             NOT NULL NUMBER(4)
// DEPARTMENT_NAME                           NOT NULL VARCHAR2(30)
// MANAGER_ID                                         NUMBER(6)
// LOCATION_ID                                        NUMBER(4)

