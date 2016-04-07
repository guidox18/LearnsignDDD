using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSign.Dominio
{
    /// <summary>
    /// 
    /// </summary>
    public class Pregunta
    {
        /// <summary>
        /// 
        /// </summary>
        public int IdPregunta { get; private set; }
        public int IdTema { get; private set; }
        public string Descripcion { get; private set; }
        public string Imagen { get; private set; }
        public string AlternativaI { get; private set; }
        public string AlternativaII { get; private set; }
        public string AlternativaIII { get; private set; }
        public string Respuesta { get; private set; }
        public virtual Tema TemaX { get; private set; }
        /// <summary>
        /// Constructor
        /// </summary>
        private Pregunta()
        {

        }
        /// <summary>
        /// Metodo para agregar Pregunta
        /// </summary>
        /// <param name="ai_id_pregunta"></param>
        /// <param name="ao_tema"></param>
        /// <param name="as_descr_pregunta"></param>
        /// <param name="as_imagen_pregunta"></param>
        /// <param name="as_alt_i_pregunta"></param>
        /// <param name="as_alt_ii_pregunta"></param>
        /// <param name="as_alt_iii_pregunta"></param>
        /// <param name="as_res_pregunta"></param>
        /// <returns></returns>
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
