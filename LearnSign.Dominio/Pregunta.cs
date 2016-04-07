using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSign.Dominio
{
    public class Pregunta
    {
        public int IdPregunta { get; private set; }
        public int IdTema { get; private set; }
        public string Descripcion { get; private set; }
        public string Imagen { get; private set; }
        public string AlternativaI { get; private set; }
        public string AlternativaII { get; private set; }
        public string AlternativaIII { get; private set; }
        public string Respuesta { get; private set; }

        public virtual Tema TemaX { get; private set; }

        private Pregunta()
        {

        }
        public static Pregunta Agregar(int ai_id_pregunta, Tema ao_tema, string as_descr_pregunta, string as_imagen_pregunta, string as_alt_i_pregunta, string as_alt_ii_pregunta, string as_alt_iii_pregunta, string as_res_pregunta)
        {
            return new Pregunta()
            {
                IdPregunta = ai_id_pregunta,
                TemaX = ao_tema,
                IdTema = ao_tema.IdTema,
                Descripcion = as_descr_pregunta,
                Imagen = as_imagen_pregunta,
                AlternativaI = as_alt_i_pregunta,
                AlternativaII = as_alt_ii_pregunta,
                AlternativaIII = as_alt_iii_pregunta,
                Respuesta = as_res_pregunta
            };
        }
        public void Actualizar(string as_descr_pregunta, string as_imagen_pregunta, string as_alt_i_pregunta, string as_alt_ii_pregunta, string as_alt_iii_pregunta, string as_res_pregunta)
        {
            Descripcion = as_descr_pregunta;
            Imagen = as_imagen_pregunta;
            AlternativaI = as_alt_i_pregunta;
            AlternativaII = as_alt_ii_pregunta;
            AlternativaIII = as_alt_iii_pregunta;
            Respuesta = as_res_pregunta;
        }

    }
}
