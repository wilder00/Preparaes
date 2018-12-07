using System.Collections.Generic;

namespace PREPARAES.Models
{
    public class Sesion
    {
        public int Id { get; set; }
        public string Tema { get; set; }
        public int NumSesion { get; set; }
        public string Objetivos { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public List<Pregunta> Preguntas { get; set; }
        public Sesion(){
            this.Preguntas = new List<Pregunta>();
        }
    }
}