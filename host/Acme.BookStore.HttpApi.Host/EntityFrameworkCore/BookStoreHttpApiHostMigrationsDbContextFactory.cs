using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.BookStore.EntityFrameworkCore;

public class BookStoreHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<BookStoreHttpApiHostMigrationsDbContext>
{
    public BookStoreHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<BookStoreHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("BookStore"));

        return new BookStoreHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
