using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Acme.BookStore.MongoDB;

public static class BookStoreMongoDbContextExtensions
{
    public static void ConfigureBookStore(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
