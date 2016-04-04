using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSign.Dominio
{
    public class Auspicio
    {
        public int IdAuspicio { get; private set; }
        public string Nombre { get; private set; }
        public string UrlFoto { get; private set; }
        public int Estado { get; private set; }

        private Auspicio()
        {

        }
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
