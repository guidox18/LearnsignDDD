using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSign.Dominio
{
    public class Adminsitrador
    {
        public int IdAdministrador { get; private set; }
        public int DNI { get; private set; }
        public string Nombre { get; private set; }
        public string Apellidos { get; private set; }
        public string Email { get; private set; }
        public string Direccion { get; private set; }
        public int Telefono { get; private set; }
        public int Celular { get; private set; }
        public int Sexo { get; private set; }
        public int Estado { get; private set; }
        public string Pass { get; private set; }

        private Adminsitrador()
        {

        }
        public static Adminsitrador Agregar(int ai_id_admin, int ai_dni_admin, string as_nom_admin, string as_apell_admin, string as_email_admin, string as_direc_admin, int ai_tel_admin, int ai_cel_admin,  int ai_sexo_admin, string as_pass_admin)
        {
            return new Adminsitrador()
            {
                IdAdministrador = ai_id_admin,
                DNI = ai_dni_admin,
                Nombre = as_nom_admin,
                Apellidos = as_apell_admin,
                Email = as_email_admin,
                Direccion = as_direc_admin,
                Telefono = ai_tel_admin,
                Celular = ai_cel_admin,
                Sexo = ai_sexo_admin,
                Estado = 1,
                Pass = as_pass_admin
            };
        }

        /// <summary>
        /// Este método actualiza datos del alumno
        /// </summary>
        /// <param name="as_nom_alumno"></param>
        /// <param name="as_apell_alumno"></param>
        /// <param name="as_email_alum"></param>
        public void Actualizar(int ai_dni_admin, string as_nom_admin, string as_apell_admin, string as_email_admin, string as_direc_admin, int ai_tel_admin, int ai_cel_admin )
        {
            DNI = ai_dni_admin;
            Nombre = as_nom_admin;
            Apellidos = as_apell_admin;
            Email = as_email_admin;
            Direccion = as_direc_admin;
            Telefono = ai_tel_admin;
            Celular = ai_cel_admin;
        }//falta estado y password
    }
}
