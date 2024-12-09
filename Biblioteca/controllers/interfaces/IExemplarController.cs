using Biblioteca.models;
using Biblioteca.models.abstractClasses;
using Biblioteca.views;

namespace Biblioteca.controllers
{
    public interface IExemplarController
    {
        void CriarNovoExemplar();
        void ExebirInformacoes(Livro exemplar);
        void EditarExemplar(Livro exemplar);
        void excluirExemplar(Livro exemplar);

    }
}