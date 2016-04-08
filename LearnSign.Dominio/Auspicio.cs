using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnsign.Dominio
{
    /// <summary>
    /// Esta clase contiene los atributos y metodos de la clase auspicios
    /// </summary>
    public class Auspicio
    {
        /// <summary>
        /// En esta seccion se encuentra los atributos
        /// </summary>
        public int IdAuspicio { get; private set; }
        public string Nombre { get; private set; }
        public string UrlFoto { get; private set; }
        public int Estado { get; private set; }
        /// <summary>
        /// Constructor
        /// </summary>
        private Auspicio()
        {

        }
        /// <summary>
        /// Este método nos permite agregar un nuevo aupicio 
        /// </summary>
        /// <param name="ai_id_aus"></param>
        /// <param name="as_nombre_aus"></param>
        /// <param name="as_urlfoto_aus"></param>
        /// <returns></returns>
        public static Auspicio Agregar(int ai_id_aus, string as_nombre_aus, string as_urlfoto_aus)
        {
            return new Auspicio()
            {
                IdAuspicio = ai_id_aus,
                Nombre = as_nombre_aus,
                UrlFoto = as_urlfoto_aus,
                Estado = 1
            };
        }
    }
}
