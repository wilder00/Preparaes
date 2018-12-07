using Microsoft.EntityFrameworkCore;

namespace PREPARAES.Models
{
    public class PreparaesContext : DbContext
    {
        public PreparaesContext(DbContextOptions<PreparaesContext> options)
        :base(options){
            
        }


        public DbSet<Pregunta> Preguntas { get; set; }
        public DbSet<Sesion> Sesiones { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        
        
    }
}