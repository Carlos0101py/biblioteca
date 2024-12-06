
using Biblioteca.controllers;
using Biblioteca.models.abstractClasses;
using Biblioteca.views;

namespace Biblioteca.interfaces
{
    public class ExemplarController : IExemplarController
    {

        private readonly ExemplarView _exemplarView;

        public ExemplarController(ExemplarView exemplar)
        {
            _exemplarView = exemplar;
        }

        public void CriarNovoExemplar(Exemplar exemplar)
        {
            throw new NotImplementedException();
        }

        public void EditarExemplar(Exemplar exemplar)
        {
            throw new NotImplementedException();
        }

        public void excluirExemplar(Exemplar exemplar)
        {
            throw new NotImplementedException();
        }

        public void ExebirInformacoes(Exemplar exemplar)
        {
            _exemplarView.ExibirInformacoes(exemplar);
        }
    }
}