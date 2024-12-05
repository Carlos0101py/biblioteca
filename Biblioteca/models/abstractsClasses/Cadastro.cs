using System;

namespace Biblioteca.models.abstractClasses
{
    public abstract class Cadastro
    {
        private int _id;
        private string _nomeUsuario;
        private string _senha;

        public Cadastro(string nomeUsuario, string senha)
        {
            _nomeUsuario = nomeUsuario;
            _senha = senha;
        }
    }
}