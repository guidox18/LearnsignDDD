using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSign.Dominio
{
    public class RedSocial
    {
        public int IdRedSocial { get; private set; }
        public int Tipo { get; private set; }
        public string Url { get; private set; }
        public int Estado { get; private set; }

        private RedSocial()
        {

        }
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
