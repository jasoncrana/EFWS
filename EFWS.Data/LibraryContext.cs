using EFWS.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EFWS.Data
{
  public class LibraryContext : DbContext
  {
    public LibraryContext(DbContextOptions options) : base(options) { }

    public DbSet<Patron> Patrons{get; set;}
  }
}