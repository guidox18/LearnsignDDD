using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSign.Dominio
   
{
    /// <summary>
    /// Esta clase contiene los atributos y metodos de la clase articulo
    /// </summary>
    public class Articulo
    {

        /// <summary>
        /// En esta seccion se encuentra los atributos
        /// </summary>
        public int IdArticulo { get; private set; }
        public string Titulo { get; private set; }
        public string Descripcion { get; private set; }
        public string urlFoto { get; private set; }
        public int Estado { get; private set; }
        /// <summary>
        /// Constructor
        /// </summary>

        private Articulo()
        {

        }
        /// <summary>
        /// Este método nos permite agregar un nuevo articulo 
        /// </summary>
        /// <param name="ai_id_art"></param>
        /// <param name="as_titulo_art"></param>
        /// <param name="as_des_art"></param>
        /// <param name="as_urlfoto_art"></param>
        /// <returns></returns>
        public static Articulo Agregar(int ai_id_art, string as_titulo_art, string as_des_art, string as_urlfoto_art)
        {
            return new Articulo()
            {
                IdArticulo = ai_id_art,
                Titulo = as_titulo_art,
                Descripcion = as_des_art,
                urlFoto = as_urlfoto_art,
                Estado = 1
            };
        }
    }
}
