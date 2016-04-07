using HRSolucion.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
namespace HRSolucion.Datos.EF.Mapeos
{
    public class RegionConfiguracion : EntityTypeConfiguration<Region>
    {
        public RegionConfiguracion()
        {
            ToTable("REGIONS", "HR");
            HasKey(k => k.IDRegion);
            Property(p => p.IDRegion).HasColumnName("REGION_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.NombreRegion).HasColumnName("REGION_NAME").IsRequired();
            Property(p => p.EstaActiva).HasColumnName("ACTIVE").IsRequired();
        }
    }
}

//Table REGIONS
// Name                                      Null?    Type
// ----------------------------------------- -------- ----------------------------
// REGION_ID                                 NOT NULL NUMBER
// REGION_NAME                                        VARCHAR2(25)