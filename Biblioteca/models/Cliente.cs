using Biblioteca.models.abstractClasses;

namespace Biblioteca.models
{
    public class Cliente : Cadastro
    {
        public Cliente(string nomeUsuario, string senha) : base(nomeUsuario, senha)
        {
            
        }
    }
}