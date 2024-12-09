using System;
using Biblioteca.controllers;
using Biblioteca.interfaces;
using Biblioteca.models;
using Biblioteca.views;
using DotNetEnv;
using System.Data.SqlClient;
using Biblioteca.config;
using Biblioteca.sql;

public class Program
{
    public static void Main()
    {
        Env.TraversePath().Load();

        string? connectionString = Environment.GetEnvironmentVariable("DBCONNECTION");

        if(!string.IsNullOrEmpty(connectionString))
        {            
            try
            {
                var db = new Database(connectionString); 
                CadastroView viewCadastro = new();           
                ExemplarView viewExemplar = new();           
                Menu Menu = new();
                var cadastroController = new CadastroController(viewCadastro, db);
                var ExemplarController = new ExemplarController(viewExemplar, db);

                ExemplarController.CriarNovoExemplar();


            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
        }  
    }
}