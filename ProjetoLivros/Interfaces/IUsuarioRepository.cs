using ProjetoLivros.Models;

namespace ProjetoLivros.Interfaces
{
    public interface IUsuarioRepository
    {
        // Adiciona um novo usuário
        void Adicionar(Usuario usuario);

        // Atualiza um usuário existente
        void Atualizar(Usuario usuario);

        // Remove um usuário pelo ID
        void Remover(int usuarioId);

        // Busca um usuário pelo ID
        Usuario BuscarPorId(int usuarioId);

        // Busca um usuário pelo e-mail
        Usuario BuscarPorEmail(string email);

        // Lista todos os usuários
        IEnumerable<Usuario> ListarTodos();
    }
}
