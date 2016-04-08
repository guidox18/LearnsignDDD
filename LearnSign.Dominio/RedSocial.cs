using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnsign.Dominio
{
    /// <summary>
    /// Esta clase contiene los atributos y metodos de la clase RedSocial
    /// </summary>
    public class RedSocial
    {
        /// <summary>
        /// En esta seccion se encuentra los atributos
        /// </summary>
        public int IdRedSocial { get; private set; }
        public int Tipo { get; private set; }
        public string Url { get; private set; }
        public int Estado { get; private set; }
        /// <summary>
        /// Constructor
        /// </summary>
        private RedSocial()
        {

        }
        /// <summary>
        /// Metodo que permite Agregar RedScial
        /// </summary>
        /// <param name="ai_id_reds"></param>
        /// <param name="ai_tipo_reds"></param>
        /// <param name="as_url_reds"></param>
        /// <returns></returns>
        public static RedSocial Agregar(int ai_id_reds, int ai_tipo_reds, string as_url_reds)
        {
            return new RedSocial()
            {
                IdRedSocial = ai_id_reds,
                Tipo = ai_tipo_reds,
                Url = as_url_reds,
                Estado = 1
            };
        }
    }
}
