using System;
using System.Collections.Generic;
using PREPARAES.Models;

namespace Preparaes.modelosDeUso
{
    public class PreguntaParaModelo
    {
        public Pregunta pregunt { get; set; }
        public List<String> listaPregunta { get; set; }

        public PreguntaParaModelo() {
            this.listaPregunta = new List<String>();
            this.pregunt = new Pregunta();
        }
    }
}