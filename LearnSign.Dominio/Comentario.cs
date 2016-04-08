using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnsign.Dominio
{
    /// <summary>
    /// Esta clase contiene los atributos y metodos de la clase comentario
    /// </summary>
    public class Comentario
    {
        /// <summary>
        /// En esta seccion se encuentra los atributos
        /// </summary>
        public int IdComentario { get; private set; }
        public int IdAlumno { get; private set; }
        public int IdTema { get; private set; }
        public string Descripcion { get; private set; }
        public DateTime Fecha { get; private set; }

        public virtual Alumno Estudiante { get; private set; }
        public virtual Tema TemaX { get; private set; }
        /// <summary>
        /// Constructor
        /// </summary>
        private Comentario()
        {

        }
        /// <summary>
        /// Este método nos permite agregar un nuevo aupicio
        /// </summary>
        /// <param name="ai_id_comentario"></param>
        /// <param name="ao_alumno"></param>
        /// <param name="ao_tema"></param>
        /// <param name="as_des_comentario"></param>
        /// <param name="adt_fec_comentario"></param>
        /// <returns></returns>
        public static Comentario Agregar(int ai_id_comentario, Alumno ao_alumno, Tema ao_tema, string as_des_comentario, DateTime adt_fec_comentario)
        {
            return new Comentario()
            {
                IdComentario = ai_id_comentario,
                Estudiante = ao_alumno,
                IdAlumno = ao_alumno.IdAlumno,
                TemaX = ao_tema,
                IdTema = ao_tema.IdTema,
                Descripcion = as_des_comentario,
                Fecha = adt_fec_comentario
            };
        }
    }
}
