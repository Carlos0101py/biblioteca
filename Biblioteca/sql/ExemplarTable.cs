using Biblioteca.config;

namespace Biblioteca.sql
{
    public class ExemplarTable
    {
        private readonly Database _db;

        public ExemplarTable (Database db)
        {
            _db = db;
        }

        public void CriarExemplarTable()
        {
            try
            {
                string query = @"
                    IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'tb_exemplar')
                    BEGIN
                        CREATE TABLE tb_exemplar(
                            Id INT PRIMARY KEY IDENTITY(1,1),
                            Titulo NVARCHAR(100) NOT NULL,
                            Autor NVARCHAR(100) NOT NULL,
                            Editora NVARCHAR(100) NOT NULL,
                            NumeroDePaginas INT NOT NULL,
                            Genero NVARCHAR(50) NOT NULL,
                            Preco FLOAT NOT NULL
                        )
                    END
                    ELSE
                    BEGIN
                        PRINT 'A tabela tb_exemplar já existe'
                    END";

                _db.ExecuteNonQuery(query);
                Console.WriteLine("Tabela tb_exemplar criada ou já existe.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar a tabela: {ex.Message}");
                throw;
            }
        }
    }
}