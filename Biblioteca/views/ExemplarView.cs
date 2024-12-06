using System;
using Biblioteca.models;
using Biblioteca.models.abstractClasses;

namespace Biblioteca.views
{
    public class ExemplarView
    {
        public void ExibirInformacoes(Exemplar livro)
        {
            Console.WriteLine("Informações:");
            Console.WriteLine($"Título: {livro.Titulo}");
            Console.WriteLine($"Autor: {livro.Autor}");
            Console.WriteLine($"Editora: {livro.Editora}");
            Console.WriteLine($"Numero De Páginas: {livro.NumeroDePaginas}");
            Console.WriteLine($"Gânero: {livro.Genero}");
            Console.WriteLine($"Preço: {livro.Preco}");
        }
    }
}