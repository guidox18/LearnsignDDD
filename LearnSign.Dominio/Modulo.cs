using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnsign.Dominio
{
    /// <summary>
    /// Esta clase contiene los atributos y metodos de la clase modulo
    /// </summary>
    public class Modulo
    {
        /// <summary>
        /// En esta seccion se encuentra los atributos
        /// </summary>
        public int IdModulo { get; private set; }
        public string Nombre { get; private set; }
        public int Posicion { get; private set; }
        public int Estado { get; private set; }
        /// <summary>
        /// Contructor
        /// </summary>
        private Modulo()
        {
            
        }
        /// <summary>
        /// Metodo para Agregar Modulo
        /// </summary>
        /// <param name="ai_id_modulo"></param>
        /// <param name="as_nom_modulo"></param>
        /// <param name="ai_posi_modulo"></param>
        /// <returns></returns>
        public static Modulo Agregar(int ai_id_modulo, string as_nom_modulo, int ai_posi_modulo)
        {
            return new Modulo()
            {
                IdModulo = ai_id_modulo,
                Nombre = as_nom_modulo,
                Posicion = ai_posi_modulo,
                Estado = 1
            };
        }

    }
}
