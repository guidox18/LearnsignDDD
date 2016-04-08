using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Learnsign.Dominio;

namespace Learnsign.Infraestructura.Contexto
{
    // contexto define la aplicacion

    public class LSContexto : DbContext
    {
        public LSContexto(string as_conexion)
            : base(as_conexion)
        {
            //Database.SetInitializer<HRContexto>(null);
            Database.SetInitializer<LSContexto>(new InicializadorDb());
        }
        public LSContexto() : base("name=CONEXIONSQL")
        {
            Database.SetInitializer<LSContexto>(new InicializadorDb());
        }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Auspicio> Auspicios { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Evaluacion> Evaluaciones { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Pregunta> Preguntas { get; set; }
        public DbSet<RedSocial> RedSociales { get; set; }
        public DbSet<Tema> Temas { get; set; }
        public DbSet<Web> Webs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrador>().HasKey(k => k.IdAdministrador);
            modelBuilder.Entity<Alumno>().HasKey(k => k.IdAlumno);
            modelBuilder.Entity<Articulo>().HasKey(k => k.IdArticulo);
            modelBuilder.Entity<Auspicio>().HasKey(k => k.IdAuspicio);
            modelBuilder.Entity<Comentario>().HasKey(k => k.IdComentario);
            modelBuilder.Entity<Evaluacion>().HasKey(k => k.IdEvaluacion);
            modelBuilder.Entity<Modulo>().HasKey(k => k.IdModulo);
            modelBuilder.Entity<Pregunta>().HasKey(k => k.IdPregunta);
            modelBuilder.Entity<RedSocial>().HasKey(k => k.IdRedSocial);
            modelBuilder.Entity<Tema>().HasKey(k => k.IdTema);
            modelBuilder.Entity<Web>().HasKey(k => k.IdWeb);
            base.OnModelCreating(modelBuilder);
        }
    }
}
