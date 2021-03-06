﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learnsign.Help;

namespace Learnsign.Dominio
{
    /// <summary>
    /// Esta clase contiene los atributos y metodos de la clase Alumno
    /// En esta clase se puede crear el factory method y aque la clase permite que se cree un campeon
    /// </summary>
    public class Alumno
    {
        /// <summary>
        /// En esta seccion se encuentra los atributos
        /// </summary>

        public int IdAlumno { get; private set; }
        public string Nombre { get; private set; }
        public string Apellidos { get; private set; }
        public string Email { get; private set; }
        public int Sexo { get; private set; }
        public int Estado { get; private set; }
        public string Pass { get; private set; }
        public Guid FichaCambioPass { get; private set; }
        public const int PassMinLength = 6;
        public const int PassMaxLength = 30;
        /// <summary>
        /// Construcctor
        /// </summary>
        private Alumno()
        {

        }
        /// <summary>
        /// Este método nos permite agregar un nuevo alumno 
        /// </summary>
        /// <param name="ai_id_alumno"></param>
        /// <param name="as_nom_alumno"></param>
        /// <param name="as_apell_alumno"></param>
        /// <param name="as_email_alum"></param>
        /// <param name="ai_sexo_alumno"></param>
        /// <param name="as_pass_alumno"></param>
        /// <returns>Devuelve un Alumno nuevo</returns>
        public static Alumno Agregar(int ai_id_alumno, string as_nom_alumno, string as_apell_alumno, string as_email_alum, int ai_sexo_alumno, string as_pass_alumno )
        {
            //El principio de Single responsibility de SOLID se aplica aqui
            //ya que la clase alumno tiene el metodo agregar que tienen la mayoria de las clases
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
        /// <summary>
        /// Este método actualiza datos del alumno
        /// </summary>
        /// <param name="as_nom_alumno"></param>
        /// <param name="as_apell_alumno"></param>
        /// <param name="as_email_alum"></param>
        public void Actualizar(string as_nom_alumno, string as_apell_alumno, string as_email_alum)
        {
            Nombre = as_nom_alumno;
            Apellidos = as_apell_alumno;
            Email = as_email_alum;
        }
        /// <summary>
        /// Este metodo modifica la contraseña del alumno
        /// </summary>
        /// <param name="as_nom_alumno"></param>
        /// <param name="as_apell_alumno"></param>
        /// <param name="as_email_alum"></param>
        public void ActualizarPass(Guid ficha, string nuevaPass, string confirmacionDePass)
        {
            if (!FichaCambioPass.Equals(ficha)){
                throw new Exception("ficha para alteracion de contraseña invalido");
            }
            SetPass(nuevaPass, confirmacionDePass);
            GenerarNuevaFichaActuPass();
        }
        /// <summary>
        /// Registra la nueva contraseña 
        /// validando: datos nulos o vacios, cantidad de caracteres o contraseñas que no coincidan
        /// </summary>
        /// <param name="nuevaPass"></param>
        /// <param name="confirmacionDePass"></param>
        private void SetPass(string nuevaPass, string confirmacionDePass)
        {
            Guard.ForNullOrEmptyDefaultMessage(Pass, "Contraseña");
            Guard.ForNullOrEmptyDefaultMessage(confirmacionDePass, "Confirmación de Contraseña");
            Guard.StringLength("Contraseña", Pass, PassMinLength, PassMaxLength);
            Guard.AreEqual(Pass, confirmacionDePass, "Las contraseñas no coinciden!");
        }
        /// <summary>
        /// Global Unique IDentifier.
        /// </summary>
        /// <returns>Devuelve un Global Unique IDentifier.</returns>
        private Guid GenerarNuevaFichaActuPass()
        {
            FichaCambioPass = Guid.NewGuid();
            return FichaCambioPass;
        }
    }
}
