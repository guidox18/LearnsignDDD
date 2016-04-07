using System.Data.Entity.ModelConfiguration;
using HRSolucion.Dominio.Entidades;

namespace HRSolucion.Datos.EF.Mapeos
{
    public class PaisConfiguracion : EntityTypeConfiguration<Pais>
    {
        public PaisConfiguracion()
        {
            ToTable("COUNTRIES", "HR");
            HasKey(k => k.IDPais);
            Property(p => p.IDPais).HasColumnName("COUNTRY_ID").IsRequired();
            Property(p => p.NombrePais).HasColumnName("COUNTRY_NAME").IsRequired();
            Property(p => p.EstaActivo).HasColumnName("ACTIVE").IsRequired();
            Property(p => p.IDRegion).HasColumnName("REGION_ID").IsRequired();
            //Ignore(p => p.Region);
            HasRequired(m => m.Region).WithMany().HasForeignKey(f => f.IDRegion);
            //HasRequired(m => m.Region).WithMany(d => d.Paises).HasForeignKey(f => f.IDRegion);
        }
    }
}
//Table COUNTRIES 
// Name                                      Null?    Type
// ----------------------------------------- -------- ----------------------------
// COUNTRY_ID                                NOT NULL CHAR(2)
// COUNTRY_NAME                                       VARCHAR2(40)
// REGION_ID                                          NUMBER
