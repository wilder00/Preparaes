using System.Collections.Generic;

namespace PREPARAES.Models
{
    public class Cursos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Ciclo { get; set; }
        public int UsuarioId { get; set; }
        public Usuarios Usuario { get; set; }
        public List<Sesiones> Sesiones { get; set; }
    }
}