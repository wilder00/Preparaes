using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Preparaes.modelosDeUso;
using PREPARAES.Models;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace Preparaes.Controllers
{
    public class PreguntaRespuestaController : Controller
    {
        
        private readonly PreparaesContext _context;


        //private List<String> listaDePreguntas;
        public PreguntaParaModelo preguntaModelo;


        public PreguntaRespuestaController(PreparaesContext _context){
            this._context = _context;
            this.preguntaModelo = new PreguntaParaModelo();
        }


        private List<String> DesordenarLista<String>(List<String> input)
        {
            List<String> arr = input;
            List<String> arrDes = new List<String>();
        
            Random randNum = new Random();
            while (arr.Count > 0)
            {
                int val = randNum.Next(0, arr.Count - 1);
                arrDes.Add(arr[val]);
                arr.RemoveAt(val);
            }
        
            return arrDes;
        }


        public IActionResult SeleccionarTema(){
            ViewBag.temas = new SelectList(_context.Sesiones,"Id","Tema");
            return View();

        }
        
        [HttpPost]
        public IActionResult SeleccionarTema(Sesion s){
            
            if(ModelState.IsValid){
                

                var preguntas = _context
                                .Preguntas
                                .Where(p => p.Id == s.Id)
                                .ToList();

                



            }
            var num = _context.Preguntas.Count();
            Random ran = new Random();
            var r = ran.Next(num)+1;
            /* 
            Random rand = new Random();
            rand.Next();
            Console.WriteLine("-------------------------------------Five random integers between 50 and 100:");
            Console.Write("{0,8:N0}", rand.Next(50, 101));
            */

            var pregu = (Pregunta) _context.Preguntas
                                .Where(p => p.Id == r)
                                .FirstOrDefault();
            HttpContext.Session.SetInt32("id",r);
            //TempData["pregunta"] = pregu;
           // this.preguntaModelo = (PreguntaParaModelo) TempData["preg"];
            this.preguntaModelo = new PreguntaParaModelo();
            this.preguntaModelo.pregunt = pregu;

            this.preguntaModelo.listaPregunta.Add(pregu.RptaCorrecta);
            this.preguntaModelo.listaPregunta.Add(pregu.RptaIncorrecta1);
            this.preguntaModelo.listaPregunta.Add(pregu.RptaIncorrecta2);

             

            var preg = this.DesordenarLista(this.preguntaModelo.listaPregunta);
            this.preguntaModelo.listaPregunta = preg;
            this.preguntaModelo.listaPregunta.Add(pregu.PreguntaString);
            

            HttpContext.Session.SetString("0",preg[0]);
            HttpContext.Session.SetString("1",preg[1]);
            HttpContext.Session.SetString("2",preg[2]);
            HttpContext.Session.SetString("3",preg[3]);

            ViewBag.pregunta = this.preguntaModelo;
            //ViewBag.numero = r;
            //ViewBag.temas = new SelectList(_context.Sesiones,"Id","Tema");
            return View("ResponderPregunta");

        }



        
        
        public IActionResult ResponderPregunta(){
            
            

            return View();

        }

       [HttpPost]
        public IActionResult ResponderPregunta(Pregunta p){
/*
            var listaDePreguntas = new List<String>();
            listaDePreguntas.Add(pregu.RptaCorrecta);
            listaDePreguntas.Add(pregu.RptaIncorrecta1);
            listaDePreguntas.Add(pregu.RptaIncorrecta2);

            listaDePreguntas = this.DesordenarLista(listaDePreguntas);
            listaDePreguntas.Add(pregu.PreguntaString);
            ViewBag.preguntas = listaDePreguntas;
            ViewBag.Pregunta = pregu;
*/
            
            //this.preguntaModelo = (PreguntaParaModelo)TempData["pregunta"];
            var r = HttpContext.Session.GetInt32("id");
            var pregu = (Pregunta) _context.Preguntas
                                .Where(m => m.Id == r)
                                .FirstOrDefault();
            

            this.preguntaModelo.listaPregunta.Add(HttpContext.Session.GetString("0"));
            this.preguntaModelo.listaPregunta.Add(HttpContext.Session.GetString("1"));
            this.preguntaModelo.listaPregunta.Add(HttpContext.Session.GetString("2"));
            this.preguntaModelo.listaPregunta.Add(pregu.PreguntaString);
            this.preguntaModelo.pregunt = pregu;
            //TempData["pregunta"]=this.preguntaModelo;
            var respuesta="";
            var letra = (string) pregu.RptaCorrecta;
            if(letra.Equals(p.RptaCorrecta)){
                respuesta = "La Respuesta es correcta";
            }else{
                respuesta = "La Respuesta es incorrecta";
            }
            ViewBag.confirRpta = respuesta;
            ViewBag.pregunta = this.preguntaModelo;
            return View(p);

        }

    }
}