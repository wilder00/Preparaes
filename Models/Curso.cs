using System.Collections.Generic;

namespace PREPARAES.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Ciclo { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public List<Sesion> Sesiones { get; set; }
        public Curso(){
            this.Sesiones = new List<Sesion>();
        }
    }
}