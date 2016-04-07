namespace HRSolucion.Dominio.Entidades
{
    public class Locacion
    {
        public int IDLocacion { get; set; }
        public string Direccion { get; set; }
        public string CodigoPostal { get; set; }
        public string Ciudad { get; set; }
        public string ProvinciaEstado { get; set; }
        public string IDPais { get; set; }
        public virtual Pais Pais { get; set; }
    }
}
