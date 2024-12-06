using Biblioteca.controllers.interfaces;
using Biblioteca.models.abstractClasses;
using Biblioteca.views;

namespace Biblioteca.controllers
{
    public class CadastroController : ICadastroController
    {

        private readonly CadastroView _cadastroView;

        public CadastroController(CadastroView cadastroView)
        {
            _cadastroView = cadastroView;
        } 

        public void CriarNovoCadastro(Cadastro cadastro)
        {
            throw new NotImplementedException();
        }

        public void EditarCadastro(Cadastro cadastro)
        {
            throw new NotImplementedException();
        }

        public void excluirCadastro(Cadastro cadastro)
        {
            throw new NotImplementedException();
        }

        public void ExebirInformacoes(Cadastro cadastro)
        {
            _cadastroView.ExebirInformacoes(cadastro);
        }
    }
}