using Microsoft.AspNetCore.Mvc;
using MVC_Escuela.BdD;
using MVC_Escuela.Models;

namespace MVC_Escuela.Controllers
{
    public class ProfesorControler : Controller
    {
        //CREATE
        [HttpGet] /*Crear acciones para dar formulario vacio y otro para recibirlo*/
        public IActionResult Create()
        {
            ProfesorViewModel profesor = new ProfesorViewModel();
            return View(profesor);
        }

        [HttpPost] //Para publicar la información nueva
        public IActionResult Create(ProfesorViewModel profesor)
        {
            ProfesorDAO.Save(profesor);
            return RedirectToAction("Index");
        }

        //READ
        [HttpGet]
        public IActionResult Detail(int id)
        {
            ProfesorViewModel profesor = ProfesorDAO.GetOne(id);

            return View(profesor);
        }

        public IActionResult Index()
        {
            List<ProfesorViewModel> profesores = ProfesorDAO.GetAll();
            return View(profesores);
        }


        //UPDATE
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ProfesorViewModel profesor = ProfesorDAO.GetOne(id);

            return View(profesor);
        }

        [HttpPost]
        public IActionResult Edit(ProfesorViewModel profesor)
        {
            ProfesorDAO.Update(profesor);
            return RedirectToAction("Index");
        }

        //DELETE
        public IActionResult Delete(int id)
        {
            ProfesorDAO.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
