using Microsoft.AspNetCore.Mvc;
using MVC_Escuela.BdD;
using MVC_Escuela.Models;

namespace MVC_Escuela.Controllers
{
    public class AlumnoControler : Controller
    {
        //CREATE
        [HttpGet] /*Crear acciones para dar formulario vacio y otro para recibirlo*/
        public IActionResult  Create()
        {
            AlumnoViewModel alumno = new AlumnoViewModel();

            // Pasar por medio de la lista Materias, las materias exitentes de la BD
            alumno.Materias = MateriaDAO.GetAll();

            return View(alumno);
        }

        [HttpPost] //Para publicar la información nueva
        public IActionResult Create(AlumnoViewModel alumno)
        {
            AlumnoDAO.Save(alumno);
            return RedirectToAction("Index");
        }

        //READ
        [HttpGet]
        public IActionResult Detail(int id)
        {
            AlumnoViewModel alumno = AlumnoDAO.GetOne(id);
            //------------------------------------------------------
            // Consultar de la BD cuales son las materias tomas por el Alumno (usando los id guardados)
            IList<MateriaViewModel> materiasTomadas = new List<MateriaViewModel>();
            materiasTomadas.Add(MateriaDAO.GetOne(alumno.iDMateria1));
            materiasTomadas.Add(MateriaDAO.GetOne(alumno.iDMateria2));
            materiasTomadas.Add(MateriaDAO.GetOne(alumno.iDMateria3));

            alumno.Materias = materiasTomadas;
            //----------------------------------------------------------


            return View(alumno);
        }

        public IActionResult Index()
        {
            List<AlumnoViewModel> alumnos = AlumnoDAO.GetAll();
            return View(alumnos);
        }


        //UPDATE
        [HttpGet]
        public IActionResult Edit(int id) {
            AlumnoViewModel alumno = AlumnoDAO.GetOne(id);

            return View(alumno);
        }

        [HttpPost]
        public IActionResult Edit(AlumnoViewModel alumno)
        {
            AlumnoDAO.Update(alumno);
            return RedirectToAction("Index");
        }

        //DELETE
        public IActionResult Delete(int id)
        {
            AlumnoDAO.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
