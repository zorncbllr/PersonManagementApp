using Microsoft.EntityFrameworkCore;
using PersonManagementApp.Models;

namespace PersonManagementApp.Data;

public class MyAppContext : DbContext
{
    public DbSet<Person> Persons { get; set; }

    public MyAppContext(DbContextOptions<MyAppContext> options) : base(options) { }
}