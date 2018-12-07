using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PREPARAES.Models;

namespace PREPARAES.Controllers
{
    public class RegistradorController : Controller
    {
        

        private readonly PreparaesContext _context;

        public RegistradorController(PreparaesContext _context){
            this._context = _context;
        }


        //Registrarse
        public IActionResult Registrarse(){
            return View();
        }

        [HttpPost]
        public IActionResult Registrarse(Usuario u){

            if(ModelState.IsValid){
                _context.Usuarios.Add(u);
                _context.SaveChanges();
                return RedirectToAction("Confirmado");
            }


            return View(u);
        }

        public IActionResult Confirmado(){
            return View();
        }


        //Iniciar sesion
        public IActionResult IniciarSesion(){
            
            return View();
        }


        //Insertar Curso
        public IActionResult InsertarCurso(){
            ViewBag.UsuarioId= 1;
            return View();
        }

        [HttpPost]
        public IActionResult InsertarCurso(Curso c){
            if(ModelState.IsValid){
                _context.Cursos.Add(c);
                _context.SaveChanges();
                return RedirectToAction("Confirmado");
            }
            ViewBag.UsuarioId= 1;
            return View(c);
        }

        public IActionResult InsertarSesion(){
            ViewBag.Cursos = new SelectList(_context.Cursos,"Id","Nombre");
            return View();
        }


        [HttpPost]
        public IActionResult InsertarSesion(Sesion s){
            if(ModelState.IsValid){
                _context.Sesiones.Add(s);
                _context.SaveChanges();
                return RedirectToAction("Confirmado");
            }
            ViewBag.Cursos = new SelectList(_context.Cursos,"Id","Nombre");
            return View(s);
        }

        

        //Insertar pregunta----------


        public IActionResult InsertarPregunta(){
            ViewBag.Sesiones = new SelectList(_context.Sesiones,"Id","Tema");
            return View();
        }

        [HttpPost]
        public IActionResult InsertarPregunta(Pregunta p){

            if(ModelState.IsValid){
                _context.Preguntas.Add(p);
                _context.SaveChanges();
                return RedirectToAction("Confirmado");
            }

            ViewBag.Sesiones = new SelectList(_context.Sesiones,"Id","Tema");
            return View(p);
        }




    }
}