using Biblioteca.models.abstractClasses;

namespace Biblioteca.models
{
    public class Livro : Exemplar
    {
        public Livro(string titulo, string autor, string editora, int numeroDePaginas, string genero, float preco) : base(titulo, autor, editora, numeroDePaginas, genero, preco)
        {
        }
    }
}