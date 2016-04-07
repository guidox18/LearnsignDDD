using System.Collections.Generic;
using System.Linq;

namespace HRSolucion.Dominio.Entidades
{
    /// <summary>
    /// Clase utilizada para la representación de una Region del mundo
    /// </summary>
    public class Region
    {
        /// <summary>
        /// Obtiene el identificador de la región
        /// </summary>
        public int IDRegion { get; private set; }
        /// <summary>
        /// Obtiene el nombre de la región
        /// </summary>
        public string NombreRegion { get; private set; }
        /// <summary>
        /// Indica si el Región se encuentra vigente o no
        /// </summary>
        public string EstaActiva { get; private set; }

        //public virtual ICollection<Pais> Paises { get; private set; }
        /// <summary>
        /// Constructor privado
        /// </summary>
        private Region()
        {
            //Paises = new List<Pais>();
        }
        /// <summary>
        /// Método que devuelve una nueva instancia de la clase región
        /// </summary>
        /// <param name="ai_id_region">Identificador de la region</param>
        /// <param name="as_nom_region">Nombre de la </param>
        /// <returns>Instancia nueva de la clase región</returns>
        public static Region Crear(int ai_id_region, string as_nom_region)
        {
            return (
                new Region() { 
                    IDRegion = ai_id_region, 
                    NombreRegion = as_nom_region, 
                    EstaActiva = "S" 
                });
        }
        /// <summary>
        /// Método que anula una región
        /// </summary>
        public void Anular() 
        {
            EstaActiva = "N";
        }

        //public void AdicionarPais(string as_id_pais, string as_nom_pais) {
        //    Paises.Add(Pais.Adicionar(as_id_pais, as_nom_pais, this));
        //}

    }
}
