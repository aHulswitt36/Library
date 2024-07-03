using Microsoft.EntityFrameworkCore;

namespace Library.Api.Models;

public class LibraryDb : DbContext
{
    public LibraryDb(DbContextOptions<LibraryDb> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
}

