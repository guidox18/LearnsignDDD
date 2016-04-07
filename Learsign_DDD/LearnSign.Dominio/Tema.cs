using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSign.Dominio
{
    public class Tema
    {
        public int IdTema { get; private set; }
        public int IdModulo { get; private set; }
        public string Nombre { get; private set; }
        public string UrlVideo { get; private set; }
        public string Descripcion { get; private set; }
        public int Estado { get; private set; }

        public virtual Modulo ModuloX { get; private set; }

        private Tema()
        {

        }
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
