using Microsoft.AspNetCore.Mvc;

namespace ProjetoAGA.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListarAlunos()
        {
            return View();
        }

        public IActionResult VerAluno()
        {
            return View();
        }

        public IActionResult CriarAluno()
        {
            return View();
        }

        public IActionResult EditarAluno()
        {
            return View();
        }

        public IActionResult RemoverAluno()
        {
            return View();
        }

        public IActionResult ApagarAluno()
        {
            return RedirectToAction("ListarAlunos");
        }

        public IActionResult ListarProfessores()
        {
            return View();
        }

        public IActionResult VerProfessor()
        {
            return View();
        }

        public IActionResult CriarProfessor()
        {
            return View();
        }

        public IActionResult EditarProfessor()
        {
            return View();
        }

        public IActionResult RemoverProfessor()
        {
            return View();
        }

        public IActionResult ApagarProfessor()
        {
            return RedirectToAction("ListarProfessores");
        }

        public IActionResult ListarCoordenadores()
        {
            return View();
        }

        public IActionResult VerCoordenador()
        {
            return View();
        }

        public IActionResult CriarCoordenador()
        {
            return View();
        }

        public IActionResult EditarCoordenador()
        {
            return View();
        }

        public IActionResult RemoverCoordenador()
        {
            return View();
        }

        public IActionResult ApagarCoordenador()
        {
            return RedirectToAction("ListarCoordenadores");
        }



    }
}
