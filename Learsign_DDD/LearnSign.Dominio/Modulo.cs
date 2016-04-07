using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSign.Dominio
{
    public class Modulo
    {
        public int IdModulo { get; private set; }
        public string Nombre { get; private set; }
        public int Posicion { get; private set; }
        public int Estado { get; private set; }

        private Modulo()
        {
            
        }
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
