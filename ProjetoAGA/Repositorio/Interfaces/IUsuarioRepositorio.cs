using ProjetoAGA.Enums;
using ProjetoAGA.Models;

namespace ProjetoAGA.Repositorio.Interfaces
{
    public interface IUsuarioRepositorio
    {
        //MÉTODOS DE LISTAGEM DE USUÁRIOS

        public Task<List<AlunoModel>>ListarAlunos();
        public Task<List<ProfessorModel>> ListarProfessores();
        public Task<List<CoordenadorModel>> ListarCoordenadores();

        //MÉTODOS DE ADIÇÃO DE USUÁRIOS

        public Task AdicionarAluno(AlunoModel aluno);
        public Task AdicionarProfessor(ProfessorModel professor);
        public Task AdicionarCoordenador(CoordenadorModel coordenador);

        //MÉTODOS DE BUSCA DE USUÁRIOS

        public Task BuscarAlunoPorId(int id);
        public Task BuscarProfessorPorId(int id);
        public Task BuscarCoordenadorPorId(int id);

        //MÉTODOS DE UPDATE DE USUÁRIOS

        public Task AtualizarAluno(AlunoModel aluno);
        public Task AtualizarProfessor(ProfessorModel professor);
        public Task AtualizarCoordenador(CoordenadorModel coordenador);

        //MÉTODOS DE REMOÇÃO DE USUÁRIOS

        public Task RemoverAluno(int id);
        public Task RemoverProfessor(int id);
        public Task RemoverCoordenador(int id);


    }
}
