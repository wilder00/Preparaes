using System;
using System.Collections.Generic;

namespace PREPARAES.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Password { get; set; }
        public string Correo { get; set; }
        public List<Curso> Cursos { get; set; }
        public Usuario(){
            this.Cursos = new List<Curso>();
        }

        
    }
}