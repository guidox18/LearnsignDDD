using HRSolucion.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace HRSolucion.Datos.EF.Mapeos
{
    public class EmpleadoConfiguracion : EntityTypeConfiguration<Empleado>
    {
        public EmpleadoConfiguracion()
        {
            ToTable("EMPLOYEES","HR");
            HasKey(k => k.IDEmpleado);
            Property(p => p.IDEmpleado).HasColumnName("EMPLOYEE_ID").IsRequired();
            Property(p => p.Nombres).HasColumnName("FIRST_NAME");
            Property(p => p.Apellidos).HasColumnName("LAST_NAME").IsRequired();
            Property(p => p.CorreoElectronico).HasColumnName("EMAIL").IsRequired();
            Property(p => p.NumeroTelefono).HasColumnName("PHONE_NUMBER");
            Property(p => p.FechaIngreso).HasColumnName("HIRE_DATE").IsRequired();
            Property(p => p.IDCargo).HasColumnName("JOB_ID").IsRequired();
            Property(p => p.Salario).HasColumnName("SALARY");
            Property(p => p.PorcentajeComision).HasColumnName("COMMISSION_PCT");
            Property(p => p.IDAdministrador).HasColumnName("MANAGER_ID");
            Property(p => p.IDDepartamento).HasColumnName("DEPARTMENT_ID");
            HasRequired(m => m.Cargo).WithMany().HasForeignKey(m => m.IDCargo);
            HasOptional(m => m.Departamento).WithMany().HasForeignKey(m => m.IDDepartamento);

            //HasRequired(m => m.Cargo).WithMany
        }
    }
}

//HR Table Descriptions
//Table EMPLOYEES
// Name                                      Null?    Type
// ----------------------------------------- -------- ----------------------------
// EMPLOYEE_ID                               NOT NULL NUMBER(6)
// FIRST_NAME                                         VARCHAR2(20)
// LAST_NAME                                 NOT NULL VARCHAR2(25)
// EMAIL                                     NOT NULL VARCHAR2(25)
// PHONE_NUMBER                                       VARCHAR2(20)
// HIRE_DATE                                          NOT NULL DATE
// JOB_ID                                             NOT NULL VARCHAR2(10)
// SALARY                                             NUMBER(8,2)
// COMMISSION_PCT                                     NUMBER(2,2)
// MANAGER_ID                                         NUMBER(6)
// DEPARTMENT_ID                                      NUMBER(4)
