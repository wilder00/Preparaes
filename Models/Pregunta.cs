using System.ComponentModel.DataAnnotations;

namespace PREPARAES.Models
{
    public class Pregunta
    {
        public int Id { get; set; }
        [Required]
        public string PreguntaString { get; set; }
        [Required]
        public string RptaCorrecta { get; set; }
        public string RptaIncorrecta1 { get; set; }
        public string RptaIncorrecta2 { get; set; }
        public string Tipo { get; set; }
        public int SesionId { get; set; }
        public Sesion Sesion { get; set; }
    }
}