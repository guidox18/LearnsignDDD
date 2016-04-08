using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnsign.Dominio
{
    /// <summary>
    /// Esta clase contiene los atributos y metodos de la clase evaluacion
    /// </summary>
    public class Evaluacion
    {
        /// <summary>
        /// En esta seccion se encuentra los atributos
        /// </summary>
        public int IdEvaluacion { get; private set; }
        public int IdAlumno { get; private set; }
        public int IdTema { get; private set; }
        public DateTime Fecha { get; private set; }
        public int Nota { get; private set; }
        public virtual Alumno Estudiante { get; private set; }
        public virtual Tema TemaX { get; private set; }
        /// <summary>
        /// Constructor
        /// </summary>
        private Evaluacion()
        {

        }
        /// <summary>
        /// Este método nos permite agregar un nuevo Evalucacion
        /// </summary>
        /// <param name="ai_id_evaluacion"></param>
        /// <param name="ao_alumno"></param>
        /// <param name="ao_tema"></param>
        /// <param name="adt_fecha_evaluacion"></param>
        /// <param name="ai_nota_evaluacion"></param>
        /// <returns></returns>
        public static Evaluacion Agregar(int ai_id_evaluacion, Alumno ao_alumno, Tema ao_tema, DateTime adt_fecha_evaluacion, int ai_nota_evaluacion)
        {
            return new Evaluacion()
            {
                IdEvaluacion = ai_id_evaluacion,
                Estudiante = ao_alumno,
                IdAlumno = ao_alumno.IdAlumno,
                TemaX = ao_tema,
                IdTema = ao_tema.IdTema,
                Fecha = adt_fecha_evaluacion,
                Nota = ai_nota_evaluacion
              
            };
        }
    }
}
