using Biblioteca.models.abstractClasses;

namespace Biblioteca.views
{
    public class CadastroView
    {
        public void ExebirInformacoes(Cadastro usuario)
        {
            Console.WriteLine("Informações:");
            Console.WriteLine($"Título: {usuario.NomeUsuario}");
            Console.WriteLine($"Título: {usuario.Email}");
        }
    }
}