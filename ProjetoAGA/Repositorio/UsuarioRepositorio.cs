using Microsoft.EntityFrameworkCore;
using ProjetoAGA.Data;
using ProjetoAGA.Enums;
using ProjetoAGA.Models;
using ProjetoAGA.Repositorio.Interfaces;

namespace ProjetoAGA.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        //INJEÇÃO DE DEPENDÊNCIA PARA O BANCO DE DADOS

        private readonly ProjetoAgaContext _projetoAGAContext;

        public UsuarioRepositorio(ProjetoAgaContext projetoAgaContext)
        {
            _projetoAGAContext = projetoAgaContext;
        }

        ///////////////////////////////////////////////////////////////////////////////////
        //IMPLEMENTAÇÃO DA INTERFACE
        //////////////////////////////////////////////////////////////////////////////

        public async Task AdicionarAluno(AlunoModel aluno)
        {
            
            await _projetoAGAContext.Aluno.AddAsync(aluno);
            await _projetoAGAContext.SaveChangesAsync();
        }

        public async Task AdicionarCoordenador(CoordenadorModel coordenador)
        {
            await _projetoAGAContext.Coordenador.AddAsync(coordenador);
            await _projetoAGAContext.SaveChangesAsync();
        }

        public async Task AdicionarProfessor(ProfessorModel professor)
        {
            await _projetoAGAContext.Professor.AddAsync(professor);
            await _projetoAGAContext.SaveChangesAsync();
        }

        public Task AtualizarAluno(AlunoModel aluno)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarCoordenador(CoordenadorModel coordenador)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarProfessor(ProfessorModel professor)
        {
            throw new NotImplementedException();
        }

        public Task BuscarAlunoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task BuscarCoordenadorPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task BuscarProfessorPorId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AlunoModel>> ListarAlunos()
        {
            return await _projetoAGAContext.Aluno.ToListAsync();
        }


        public async Task<List<CoordenadorModel>> ListarCoordenadores()
        {
            return await _projetoAGAContext.Coordenador.ToListAsync();
        }

        public async Task<List<ProfessorModel>> ListarProfessores()
        {
            return await _projetoAGAContext.Professor.ToListAsync();
        }

        public Task RemoverAluno(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoverCoordenador(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoverProfessor(int id)
        {
            throw new NotImplementedException();
        }
    }
}
