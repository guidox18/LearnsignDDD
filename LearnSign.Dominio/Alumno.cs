using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSign.Dominio
{
    public class Alumno
    {
        public int IdAlumno { get; private set; }
        public string Nombre { get; private set; }
        public string Apellidos { get; private set; }
        public string Email { get; private set; }
        public int Sexo { get; private set; }
        public int Estado { get; private set; }
        public string Pass { get; private set; }

        private Alumno()
        {

        }
        public static Alumno Agregar(int ai_id_alumno, string as_nom_alumno, string as_apell_alumno, string as_email_alum, int ai_sexo_alumno, string as_pass_alumno )
        {
            return new Alumno()
            {
                IdAlumno = ai_id_alumno,
                Nombre = as_nom_alumno,
                Apellidos = as_apell_alumno,
                Email = as_email_alum,
                Sexo = ai_sexo_alumno,
                Estado = 1,
                Pass= as_pass_alumno
            };
        }

    }
}
