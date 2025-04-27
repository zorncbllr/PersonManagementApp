
namespace PersonManagementApp.Models;

public class Person
{
    public int PersonId { get; set; }

    required public DateTime DateOfBirth { get; set; }

    required public string FirstName { get; set; }

    required public string LastName { get; set; }

    required public string BirthPlace { get; set; }

    required public string Gender { get; set; }

    required public string Religion { get; set; }
}