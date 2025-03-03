using Dapper;
using Microsoft.Data.SqlClient;

namespace backend.Data
{
    public class DataAccess : IDisposable
    {
        private SqlConnection connection;
        public DataAccess(IConfiguration configuration) { 
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void Dispose()
        {
            if (connection != null)
            {
                connection.Dispose();
                connection.Close();
            }
        }

        public bool RegisterUser(string email, string password, string role)
        {
            var accountCount = connection.ExecuteScalar<int>("SELECT COUNT(1) FROM [UserAccount] WHERE [Email] = @email", new { email = email });
            if (accountCount > 0) return false;

            var query = "INSERT INTO [UserAccount] (Email, Password, Role) VALUES (@email, @password, @role)";
            var result = connection.Execute(query, new { email = email, password = password, role = role });

            return result > 0;
        }
    }
}
