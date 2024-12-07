
using Microsoft.Data.SqlClient;

namespace Biblioteca.config
{
    public class Database
    {
        private readonly string _connectionString;

        public Database(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlConnection GetConnection()
        {
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection;
        }

        public int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using var connection = GetConnection();
            using var command = new SqlCommand(query, connection);
            command.Parameters.AddRange(parameters);
            return command.ExecuteNonQuery();
        }

        public void ExecuteReader(string query, Action<SqlDataReader> readAction, params SqlParameter [] parameters)
        {
            using var connection = GetConnection();
            using var command = new SqlCommand(query, connection);
            command.Parameters.AddRange(parameters);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                readAction(reader);
            }
        }
    }
}