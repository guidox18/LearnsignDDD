
namespace HRSolucion.Dominio.Entidades
{
    public class Departamento
    {
        public int IDDepartamento { get; set; }
        public string NombreDepartamento { get; set; }
        public int? IDAdministrador { get; set; }
        public int? IDLocacion { get; set; }
        public virtual Locacion Locacion { get; set; }
    }
}
