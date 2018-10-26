using System.Collections.Generic;

namespace PREPARAES.Models
{
    public class Sesiones
    {
        public int Id { get; set; }
        public string Tema { get; set; }
        public int NumSesion { get; set; }
        public string Objetivos { get; set; }
        public int CursoId { get; set; }
        public Cursos Curso { get; set; }
        public List<Preguntas> Preguntas { get; set; }
    }
}