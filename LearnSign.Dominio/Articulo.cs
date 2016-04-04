using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSign.Dominio
{
    public class Articulo
    {
        public int IdArticulo { get; private set; }
        public string Titulo { get; private set; }
        public string Descripcion { get; private set; }
        public string urlFoto { get; private set; }
        public int Estado { get; private set; }

        private Articulo()
        {

        }
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
