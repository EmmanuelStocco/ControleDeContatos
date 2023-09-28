using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel BuscarPorLogin(string login);
        UsuarioModel BuscarPorEmailELogin(string email, string login);

        List<UsuarioModel> BuscarTodos();
        UsuarioModel ListarPorId(int id);
        UsuarioModel Adicionar(UsuarioModel contato);
        UsuarioModel Atualizar(UsuarioModel contato);

        UsuarioModel AlterarSenha(AlterarSenhaModel alterarSenhaModel);
        
        bool Apagar(int id);

    }
}
