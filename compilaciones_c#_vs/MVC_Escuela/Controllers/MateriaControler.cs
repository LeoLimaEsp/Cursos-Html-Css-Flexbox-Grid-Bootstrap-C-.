using Microsoft.AspNetCore.Mvc;
using MVC_Escuela.BdD;
using MVC_Escuela.Models;

namespace MVC_Escuela.Controllers
{
    public class MateriaControler : Controller
    {
        //READ
        [HttpGet]
        public IActionResult Detail(int id)
        {
            MateriaViewModel materia = MateriaDAO.GetOne(id);

            return View(materia);
        }

        public IActionResult Index()
        {
            List<MateriaViewModel> materias = MateriaDAO.GetAll();
            return View(materias);
        }

        //CREATE
        [HttpGet] /*Crear acciones para dar formulario vacio y otro para recibirlo*/
        public IActionResult Create()
        {
            MateriaViewModel materia = new MateriaViewModel();
            return View(materia);
        }

        [HttpPost] //Para publicar la información nueva
        public IActionResult Create(MateriaViewModel materia)
        {
            MateriaDAO.Save(materia);
            return RedirectToAction("Index");
        }

        //UPDATE
        [HttpGet]
        public IActionResult Edit(int id)
        {
            MateriaViewModel materia = MateriaDAO.GetOne(id);

            return View(materia);
        }

        [HttpPost]
        public IActionResult Edit(MateriaViewModel materia)
        {
            MateriaDAO.Update(materia);
            return RedirectToAction("Index");
        }

        //DELETE
        public IActionResult Delete(int id)
        {
            MateriaDAO.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
