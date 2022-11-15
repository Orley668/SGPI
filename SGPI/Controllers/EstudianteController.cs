using Microsoft.AspNetCore.Mvc;
using SGPI.Models;
using System.Linq;

namespace SGPI.Controllers
{
    public class EstudianteController : Controller
    {
        SGPIDBContext context = new SGPIDBContext();
     
        public IActionResult ActualizarEstudiante()
        {
          
                ViewBag.genero = context.Generos.ToList();
                ViewBag.documento = context.Documentos.ToList();
                ViewBag.rol = context.Rols.ToList();
                ViewBag.programa = context.Programas.ToList();
                return View();
            
           
        }

        [HttpPost]
        public IActionResult ActualizarEstudiante(Usuario user)
        {
            context.Update(user);
            context.SaveChanges();
            ViewBag.genero = context.Generos.ToList();
            ViewBag.documento = context.Documentos.ToList();
            ViewBag.rol = context.Rols.ToList();
            ViewBag.programa = context.Programas.ToList();
            return View();


        }

        public IActionResult PagosEstudiante()
        {
        
          
            return View();
        }
       
    }
}

    

