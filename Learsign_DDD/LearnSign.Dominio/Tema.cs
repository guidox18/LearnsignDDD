using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSign.Dominio
{
    /// <summary>
    /// Esta clase contiene los atributos y metodos de la clase Tema
    /// </summary>
    public class Tema
    {
        /// <summary>
        /// En esta seccion se encuentra los atributos
        /// </summary>
        public int IdTema { get; private set; }
        public int IdModulo { get; private set; }
        public string Nombre { get; private set; }
        public string UrlVideo { get; private set; }
        public string Descripcion { get; private set; }
        public int Estado { get; private set; }
        public virtual Modulo ModuloX { get; private set; }
        /// <summary>
        /// Constructor
        /// </summary>
        private Tema()
        {

        }
        /// <summary>
        /// Metodo que nos Permite Agregar Tema
        /// </summary>
        /// <param name="ai_id_tema"></param>
        /// <param name="ao_modulo"></param>
        /// <param name="as_nombre_tema"></param>
        /// <param name="as_urlv_tema"></param>
        /// <param name="ai_descr_tema"></param>
        /// <returns></returns>
        public static Tema Agregar(int ai_id_tema, Modulo ao_modulo, string as_nombre_tema, string as_urlv_tema, string ai_descr_tema )
        {
            return new Tema()
            {
                IdTema = ai_id_tema,
                ModuloX = ao_modulo,
                IdModulo = ao_modulo.IdModulo,
                Nombre = as_nombre_tema,
                UrlVideo = as_urlv_tema,
                Descripcion = ai_descr_tema,
                Estado = 1
            };
        }
    }
}
