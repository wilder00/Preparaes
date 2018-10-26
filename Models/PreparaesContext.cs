using Microsoft.EntityFrameworkCore;

namespace PREPARAES.Models
{
    public class PreparaesContext : DbContext
    {
        public PreparaesContext(DbContextOptions<PreparaesContext> options)
        :base(options){
            
        }


        public DbSet<Preguntas> Preguntas { get; set; }
        public DbSet<Sesiones> Sesiones { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        
        
    }
}