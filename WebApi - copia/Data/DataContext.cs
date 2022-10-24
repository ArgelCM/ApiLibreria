using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data;

public class DataContext: DbContext
{
    public DataContext(DbContextOptions<DataContext> options): base (options) {

    }   

    protected override void OnModelCreating(ModelBuilder builder){
        builder.Entity<Book>()
            .HasOne(e => e.Author)
            .WithMany(e => e.Books)
            .IsRequired(false);

        builder.Entity<Book>()
            .HasOne(e => e.Editorial)
            .WithMany(e => e.Books)
            .IsRequired(false);

            builder.Entity<Prestamo>()
            .HasOne(e => e.Usuario)
            .WithMany(e => e.Prestamos)
            .IsRequired(false);


    }
        
    public DbSet<Book> Books { get; set; } = default!;

    public DbSet<Author> Authors { get; set; } = default!;
    
    public DbSet<Editorial> Editorials { get; set; } = default!;


}