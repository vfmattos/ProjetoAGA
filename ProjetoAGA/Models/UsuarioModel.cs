using ProjetoAGA.Enums;

namespace ProjetoAGA.Models
{
    public class UsuarioModel
    {

        public int Id { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Sexo { get; set; }
        public string? Email { get; set; }
        public string? Nacionalidade { get; set; }
        public string? Endereco { get; set; }
        public string? Uf { get; set; }
        public string? Cpf { get; set; }
        public string? Rg { get; set; }
        public string? Celular { get; set; }
        public PerfilUsuario Perfil { get; set; }

    }
}
