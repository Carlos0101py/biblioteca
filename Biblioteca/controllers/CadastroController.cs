using Biblioteca.config;
using Biblioteca.controllers.interfaces;
using Biblioteca.models.abstractClasses;
using Biblioteca.views;

namespace Biblioteca.controllers
{
    public class CadastroController : ICadastroController
    {

        private readonly CadastroView _cadastroView;
        private readonly Database _dataBase;

        public CadastroController(CadastroView cadastroView, Database database)
        {
            _cadastroView = cadastroView;
            _dataBase = database;
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