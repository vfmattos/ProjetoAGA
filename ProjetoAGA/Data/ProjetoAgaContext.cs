using Microsoft.EntityFrameworkCore;
using ProjetoAGA.Models;

namespace ProjetoAGA.Data
{
    public class ProjetoAgaContext : DbContext
    {

        public ProjetoAgaContext(DbContextOptions<ProjetoAgaContext> options) : base(options)
        {     
        }

        public DbSet<AdminModel> Admin { get; set; }
        public DbSet<CoordenadorModel> Coordenador { get; set; }
        public DbSet<ProfessorModel> Professor { get; set;}
        public DbSet<AlunoModel> Aluno { get; set; }

    }
}
