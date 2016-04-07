using HRSolucion.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace HRSolucion.Datos.EF.Mapeos
{
    internal class CargoConfiguracion : EntityTypeConfiguration<Cargo>
    {
        public CargoConfiguracion()
        {
            ToTable("JOBS","HR");
            HasKey(k => k.IDCargo);
            Property(p => p.IDCargo).HasColumnName("JOB_ID").IsRequired();
            Property(p => p.TituloCargo).HasColumnName("JOB_TITLE").IsRequired();
            Property(p => p.SalarioMaximo).HasColumnName("MIN_SALARY");
            Property(p => p.SalarioMaximo).HasColumnName("MAX_SALARY");
        }
    }
}
//Table JOBS
// Name                                      Null?    Type
// ----------------------------------------- -------- ----------------------------
// JOB_ID                                    NOT NULL VARCHAR2(10)
// JOB_TITLE                                 NOT NULL VARCHAR2(35)
// MIN_SALARY                                         NUMBER(6)
// MAX_SALARY                                         NUMBER(6)

//Table JOB_HISTORY
// Name                                      Null?    Type
// ----------------------------------------- -------- ----------------------------
// EMPLOYEE_ID                               NOT NULL NUMBER(6)
// START_DATE                                NOT NULL DATE
// END_DATE                                  NOT NULL DATE
// JOB_ID                                    NOT NULL VARCHAR2(10)
// DEPARTMENT_ID                                      NUMBER(4)
