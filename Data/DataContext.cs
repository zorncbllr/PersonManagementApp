using System.Data;
using Npgsql;

namespace PersonManagementApp.Data;

public class DataContext
{
    private readonly string _connectionString;

    public DataContext(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    public IDbConnection CreateConnection()
    {
        return new NpgsqlConnection(_connectionString);
    }

}