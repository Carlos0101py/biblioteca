using Biblioteca.models.abstractClasses;

namespace Biblioteca.models
{
    public class Cliente : Cadastro
    {
        public Cliente(string nomeUsuario, string email, string senha) : base(nomeUsuario, email, senha)
        {
        }
    }
}