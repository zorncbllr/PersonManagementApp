using System.Data;
using Dapper;
using PersonManagementApp.Data;
using PersonManagementApp.Models;

namespace PersonManagementApp.Repositories;

public class PersonRepository
{
    private readonly IDbConnection _connection;

    public PersonRepository(DataContext context)
    {
        _connection = context.CreateConnection();
    }

    public async Task<IEnumerable<Person>> GetAllPersonsAsync()
    {
        string sql = "SELECT * FROM persons";

        return await _connection.QueryAsync<Person>(sql);
    }

    public async Task<Person?> GetPersonByIdAsync(int id)
    {
        string sql = "SELECT * FROM persons WHERE personId = @personId";

        return await _connection.QuerySingleOrDefaultAsync<Person>(sql, new { personId = id });
    }

    public async Task CreatePersonAsync(Person person)
    {
        string sql = "INSERT INTO persons (firstName, lastName, gender, birthplace, religion, dateOfBirth) VALUES (@FirstName, @LastName, @Gender, @BirthPlace, @Religion, @DateOfBirth)";

        await _connection.ExecuteAsync(sql, person);
    }

    public async Task DeletePersonAsync(int personId)
    {
        string sql = "DELETE FROM persons WHERE personId = @personId";

        await _connection.ExecuteAsync(sql, new { personId = personId });
    }
}