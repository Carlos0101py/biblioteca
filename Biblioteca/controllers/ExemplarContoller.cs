
using Biblioteca.config;
using Biblioteca.controllers;
using Biblioteca.models;
using Biblioteca.models.abstractClasses;
using Biblioteca.sql;
using Biblioteca.views;

namespace Biblioteca.interfaces
{
    public class ExemplarController : IExemplarController
    {

        private readonly ExemplarView _exemplarView;
        private readonly Database _dataBase;

        public ExemplarController(ExemplarView exemplar, Database database)
        {
            _exemplarView = exemplar;
            _dataBase = database;
        }

        public void CriarNovoExemplar()
        {
            string titulo;
            string autor;
            string editora;
            int numeroDePaginas;
            string genero;
            float preco;

            string entrada;

            Console.WriteLine("Nome:");
            titulo = Console.ReadLine();
            Console.WriteLine("Auto:");
            autor = Console.ReadLine();
            Console.WriteLine("Editora");
            editora = Console.ReadLine();
            Console.WriteLine("Nº de paginas:");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out numeroDePaginas);
            Console.WriteLine("Genero:");
            genero = Console.ReadLine();
            Console.WriteLine("Preço:");
            entrada = Console.ReadLine();
            float.TryParse(entrada, out preco);

            Livro livro = new Livro(titulo, autor, editora, numeroDePaginas, genero, preco);

            InsertionData.InsertionIntoExemplarTable(livro, _dataBase);

        }

        public void EditarExemplar(Livro exemplar)
        {
            throw new NotImplementedException();
        }

        public void excluirExemplar(Livro exemplar)
        {
            throw new NotImplementedException();
        }

        public void ExebirInformacoes(Livro exemplar)
        {
            _exemplarView.ExibirInformacoes(exemplar);
        }
    }
}