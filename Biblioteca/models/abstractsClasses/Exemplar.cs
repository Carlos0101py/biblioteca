

namespace Biblioteca.models.abstractClasses
{
    public abstract class Exemplar
    {
        private int _id;
        private string _titulo;
        private string _autor;
        private string _editora; 
        private int _numeroDePaginas;
        private string _genero;
        private float _preco;

        public Exemplar(string titulo, string autor, string editora, int numeroDePaginas, string genero, float preco)
        {
            _titulo = titulo;
            _autor = autor;
            _editora = editora;
            _numeroDePaginas = numeroDePaginas;
            _genero = genero;
            _preco = preco;
        }

        public String Titulo
        {
            get => _titulo;
            set 
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O campo titulo não pode ser vazio!");
                }
                
                _titulo = value;
            }
        }

        public String Autor
        {
            get => _autor;
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O campo autor não pode ser vazio!");
                }

                _autor = value;
            }
        }

        public String Editora
        {
            get => _editora;
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O campo editora não pode ser vazio!");
                }

                _editora = value;
            }
        }

        public int NumeroDePaginas
        {
            get => _numeroDePaginas;
            set 
            {
                if(value % 1 != 0)
                {
                    throw new ArgumentException("O campo Numero de paginas não é valido!");
                }

                _numeroDePaginas = value;
            }
        }

        public string Genero
        {
            get => _genero;
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O campo genero não pode ser vazio!");
                }

                _genero = value;
            }
        }

        public float Preco
        {
            get => _preco;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O preço não pode ser negativo.");
                }
                _preco = value;
            }
        }
    }
}