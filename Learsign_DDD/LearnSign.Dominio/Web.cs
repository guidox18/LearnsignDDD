using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSign.Dominio
{
    public class Web
    {
        public int IdWeb { get; private set; }
        public string UrlLogo { get; private set; }
        public string Titulo { get; private set; }
        public string Subtitulo { get; private set; }
        public string Pie { get; private set; }

        private Web()
        {

        }
        public static Web Agregar(int ai_id_web, string as_urllogo_web, string as_titulo_web, string as_subtitulo_web, string as_pie_web)
        {
            return new Web()
            {
                IdWeb = ai_id_web,
                UrlLogo = as_urllogo_web,
                Titulo = as_titulo_web,
                Subtitulo = as_subtitulo_web,
                Pie= as_pie_web
            };
        }
    }
}
