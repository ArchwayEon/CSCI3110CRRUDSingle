using CSCI3110CRRUDSingle.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CSCI3110CRRUDSingle.Services;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Person> People => Set<Person>();
}

