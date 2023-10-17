using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.BookStore.EntityFrameworkCore;

public class BookStoreHttpApiHostMigrationsDbContext : AbpDbContext<BookStoreHttpApiHostMigrationsDbContext>
{
    public BookStoreHttpApiHostMigrationsDbContext(DbContextOptions<BookStoreHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureBookStore();
    }
}
