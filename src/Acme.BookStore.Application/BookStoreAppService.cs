using Acme.BookStore.Localization;
using Volo.Abp.Application.Services;

namespace Acme.BookStore;

public abstract class BookStoreAppService : ApplicationService
{
    protected BookStoreAppService()
    {
        LocalizationResource = typeof(BookStoreResource);
        ObjectMapperContext = typeof(BookStoreApplicationModule);
    }
}
