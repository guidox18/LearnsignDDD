using System.Data.Entity.ModelConfiguration;
using HRSolucion.Dominio.Entidades;


namespace HRSolucion.Datos.EF.Mapeos
{
    public class LocacionConfiguracion : EntityTypeConfiguration<Locacion>
    {
        public LocacionConfiguracion()
        {
            ToTable("LOCATIONS", "HR");
            HasKey(k => k.IDLocacion);
            Property(p => p.IDLocacion).HasColumnName("LOCATION_ID").IsRequired();
            Property(p => p.Direccion).HasColumnName("STREET_ADDRESS");
            Property(p => p.CodigoPostal).HasColumnName("POSTAL_CODE");
            Property(p => p.Ciudad).HasColumnName("CITY").IsRequired();
            Property(p => p.ProvinciaEstado).HasColumnName("STATE_PROVINCE");
            Property(p => p.IDPais).HasColumnName("COUNTRY_ID");
            HasOptional(m => m.Pais).WithMany().HasForeignKey(m => m.IDPais);

        }
    }
}

//Table LOCATIONS
// Name                                      Null?    Type
// ----------------------------------------- -------- ----------------------------
// LOCATION_ID                               NOT NULL NUMBER(4)
// STREET_ADDRESS                                     VARCHAR2(40)
// POSTAL_CODE                                        VARCHAR2(12)
// CITY                                      NOT NULL VARCHAR2(30)
// STATE_PROVINCE                                     VARCHAR2(25)
// COUNTRY_ID                                         CHAR(2)

