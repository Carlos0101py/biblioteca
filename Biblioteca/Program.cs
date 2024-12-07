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

                var exemplarTable = new ExemplarTable(db); 
                exemplarTable.CriarExemplarTable();

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
        }  
    }
}