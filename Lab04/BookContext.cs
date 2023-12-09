
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
namespace Lab04;

public class BookContext : DbContext
{
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().Property(b => b.Genres).HasConversion(
            v => string.Join(',', v),
            v => v.Split(new[] { ',' }, StringSplitOptions.None).ToList());
        modelBuilder.Entity<Book>().Property(b => b.Tags).HasConversion(
            v => string.Join(',', v),
            v => v.Split(new[] { ',' }, StringSplitOptions.None).ToList());
    }
}
