using Biblioteca.config;
using Biblioteca.models;
using Biblioteca.models.abstractClasses;
using Microsoft.Data.SqlClient;

namespace Biblioteca.sql;

public static class InsertionData
{
    public static void InsertionIntoExemplarTable(Livro dados, Database db)
    {
        string insertQuery = "INSERT INTO tb_exemplar (Titulo, Autor, Editora, NumeroDePaginas, Genero, Preco) " + "VALUES (@Titulo, @Autor, @Editora, @NumeroDePaginas, @Genero, @Preco)";

        var parameters = new[]
        {
            new SqlParameter("@Titulo", dados.Titulo),
            new SqlParameter("@Autor", dados.Autor),
            new SqlParameter("@Editora", dados.Editora),
            new SqlParameter("@NumeroDePaginas", dados.NumeroDePaginas),
            new SqlParameter("@Genero", dados.Genero),
            new SqlParameter("@Preco", dados.Preco)
        };

        db.ExecuteNonQuery(insertQuery, parameters);
    }
}