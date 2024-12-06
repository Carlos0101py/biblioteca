using Biblioteca.models;
using Biblioteca.models.abstractClasses;
using Biblioteca.views;

namespace Biblioteca.controllers
{
    public interface IExemplarController
    {
        void CriarNovoExemplar(Exemplar exemplar);
        void ExebirInformacoes(Exemplar exemplar);
        void EditarExemplar(Exemplar exemplar);
        void excluirExemplar(Exemplar exemplar);

    }
}