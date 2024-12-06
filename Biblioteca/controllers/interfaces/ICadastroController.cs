
using Biblioteca.models.abstractClasses;

namespace Biblioteca.controllers.interfaces
{
    public interface ICadastroController
    {
        void CriarNovoCadastro(Cadastro cadastro);
        void ExebirInformacoes(Cadastro cadastro);
        void EditarCadastro(Cadastro cadastro);
        void excluirCadastro(Cadastro cadastro);
    }
}