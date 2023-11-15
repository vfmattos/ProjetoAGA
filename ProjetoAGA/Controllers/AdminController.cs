using Microsoft.AspNetCore.Mvc;
using ProjetoAGA.Models;
using ProjetoAGA.Repositorio.Interfaces;

namespace ProjetoAGA.Controllers
{
    public class AdminController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public AdminController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }


        //GET ACTIONS

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ListarAlunos()
        {

            var alunos = await _usuarioRepositorio.ListarAlunos();

            return View(alunos);
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

        public async Task<IActionResult> ListarProfessores()
        {
            var professores = await _usuarioRepositorio.ListarProfessores();
            return View(professores);
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

        public async Task<IActionResult> ListarCoordenadores()
        {
            var coordenadores = await _usuarioRepositorio.ListarCoordenadores();
            return View(coordenadores);
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

        //POST ACTIONS

        [HttpPost]

        public async Task<IActionResult> CriarAluno(AlunoModel aluno)
        {
            await _usuarioRepositorio.AdicionarAluno(aluno);
            return RedirectToAction("ListarAlunos");
        }

        [HttpPost]

        public async Task<IActionResult> CriarProfessor(ProfessorModel professor)
        {
            await _usuarioRepositorio.AdicionarProfessor(professor);
            return RedirectToAction("ListarProfessores");
        }

        [HttpPost]

        public async Task<IActionResult> CriarCoordenador(CoordenadorModel coordenador)
        {
            await _usuarioRepositorio.AdicionarCoordenador(coordenador);
            return RedirectToAction("ListarCoordenadores");
        }


    }
}
