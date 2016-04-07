namespace HRSolucion.Dominio.Entidades
{
    /// <summary>
    /// Clase utilizada para la representación de un Pais del mundo
    /// </summary>
    public class Pais
    {
        /// <summary>
        /// Identificador del Pais
        /// </summary>
        public string IDPais { get; private set; }
        /// <summary>
        /// Nombre dle Pais
        /// </summary>
        public string NombrePais { get; private set; }
        /// <summary>
        /// Indica si el País se encuentra vigente o no
        /// </summary>
        public string EstaActivo { get; private set; }
        /// <summary>
        /// Identificador de la Región a la que pertenece el País
        /// </summary>
        public int IDRegion { get; set; }
        /// <summary>
        /// Región a la que pertenece el País
        /// </summary>
        public Region Region { get; set; }
        /// <summary>
        /// Constructor Privado
        /// </summary>
        private Pais()
        {
        }
        public static Pais Crear(string as_id_pais, string as_nom_pais, Region ao_region)
        {
            return (new Pais()
            {
                IDPais = as_id_pais,
                NombrePais = as_nom_pais,
                EstaActivo = "S",
                IDRegion = ao_region.IDRegion/*,
                Region = ao_region*/
            });
        }
        internal static Pais Adicionar(string as_id_pais, string as_nom_pais, Region ao_region)
        {
            return (new Pais()
            {
                IDPais = as_id_pais,
                NombrePais = as_nom_pais,
                EstaActivo = "S",
                IDRegion = ao_region.IDRegion/*,
                Region = ao_region*/
            });
        }
    }
}
