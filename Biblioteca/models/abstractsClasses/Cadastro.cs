using System;

namespace Biblioteca.models.abstractClasses
{
    public abstract class Cadastro
    {
        private int _id;
        private string _nomeUsuario;
        private string _email;
        private string _senha;

        public Cadastro(string nomeUsuario, string email, string senha)
        {
            _nomeUsuario = nomeUsuario;
            _email = email;
            _senha = senha;
        }

        public string NomeUsuario
        {
            get => _nomeUsuario;
            set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O campo não pode ser vazio");
                }

                _nomeUsuario = value;
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O campo não pode ser vazio");
                }

                _email = value;
            }
        }

        public string Senha
        {

            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O campo não pode ser vazio");
                }

                _senha = value;
            }
        }
    }
}