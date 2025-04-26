using System.ComponentModel.DataAnnotations.Schema;

namespace PersonManagementApp.Models;

public class Person
{
    public int PersonId { get; set; }
    required public DateOnly DateOfBirth { get; set; }


    [Column(TypeName = "varchar(50)")]
    required public string FirstName { get; set; }

    [Column(TypeName = "varchar(50)")]
    required public string LastName { get; set; }

    [Column(TypeName = "varchar(100)")]
    required public string BirthPlace { get; set; }

    [Column(TypeName = "varchar(20)")]
    required public string Gender { get; set; }

    [Column(TypeName = "varchar(100)")]
    required public string Religion { get; set; }
}