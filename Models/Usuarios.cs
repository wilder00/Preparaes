using System.Collections.Generic;

namespace PREPARAES.Models
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string password { get; set; }
        public string Correo { get; set; }
        public List<Cursos> Cursos { get; set; }
    }
}