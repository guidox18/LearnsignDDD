using Learnsign.Help;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnsign.Dominio
{
    /// <summary>
    /// Esta clase contiene los atributos y metodos de la clase Administrador
    /// En esta clase se puede crear el factory method y aque la clase permite que se cree un campeon
    /// </summary>
    public class Administrador
    {
        /// <summary>
        /// En esta seccion se encuentra los atributos
        /// </summary>
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
        public Guid FichaCambioPass { get; private set; }
        public const int PassMinLength = 6;
        public const int PassMaxLength = 30;
        /// <summary>
        /// Constructor
        /// </summary>
        private Administrador()
        {

        }
        /// <summary>
        /// Este método nos permite agregar un nuevo alumno 
        /// </summary>
        /// <param name="ai_id_admin"></param>
        /// <param name="ai_dni_admin"></param>
        /// <param name="as_nom_admin"></param>
        /// <param name="as_apell_admin"></param>
        /// <param name="as_email_admin"></param>
        /// <param name="as_direc_admin"></param>
        /// <param name="ai_tel_admin"></param>
        /// <param name="ai_cel_admin"></param>
        /// <param name="ai_sexo_admin"></param>
        /// <param name="as_pass_admin"></param>
        /// <returns></returns>
        public static Administrador Agregar(int ai_id_admin, int ai_dni_admin, string as_nom_admin, string as_apell_admin, string as_email_admin, string as_direc_admin, int ai_tel_admin, int ai_cel_admin,  int ai_sexo_admin, string as_pass_admin)
        {
            return new Administrador()
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
        /*public void Actualizar(int ai_dni_admin, string as_nom_admin, string as_apell_admin, string as_email_admin, string as_direc_admin, int ai_tel_admin, int ai_cel_admin )
        {
            DNI = ai_dni_admin;
            Nombre = as_nom_admin;
            Apellidos = as_apell_admin;
            Email = as_email_admin;
            Direccion = as_direc_admin;
            Telefono = ai_tel_admin;
            Celular = ai_cel_admin;
        }*/

        /*public void ActualizarPass(Guid ficha, string nuevaPass, string confirmacionDePass)
        {
            if (!FichaCambioPass.Equals(ficha))
            {
                throw new Exception("ficha para alteracion de contraseña invalido");
            }
            SetPass(nuevaPass, confirmacionDePass);
            GenerarNuevaFichaActuPass();
        }*/

        /*private void SetPass(string nuevaPass, string confirmacionDePass)
        {
            Guard.ForNullOrEmptyDefaultMessage(Pass, "Contraseña");
            Guard.ForNullOrEmptyDefaultMessage(confirmacionDePass, "Confirmación de Contraseña");
            Guard.StringLength("Contraseña", Pass, PassMinLength, PassMaxLength);
            Guard.AreEqual(Pass, confirmacionDePass, "Las contraseñas no coinciden!");
        }

        private Guid GenerarNuevaFichaActuPass()
        {
            FichaCambioPass = Guid.NewGuid();
            return FichaCambioPass;
        }*/

    }
}
