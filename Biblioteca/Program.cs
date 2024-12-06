using System;
using Biblioteca.controllers;
using Biblioteca.interfaces;
using Biblioteca.models;
using Biblioteca.views;


public class Program
{
    public static void Main()
    {
        Livro livro1 = new Livro("meu ovo de chapel", "carlos", "brasilio", 10, "acao", 1);

        ExemplarView view = new ExemplarView();

        ExemplarController controller = new ExemplarController(view);

        controller.ExebirInformacoes(livro1);

    }

}