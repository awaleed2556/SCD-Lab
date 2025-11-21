using Microsoft.EntityFrameworkCore;
using HEHE.Models.Entities;
namespace HEHE.Models;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base (options) { }
    public DbSet<Products> products { get; set; }
}
