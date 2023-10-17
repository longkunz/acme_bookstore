using Acme.BookStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStore;

public abstract class BookStoreController : AbpControllerBase
{
    protected BookStoreController()
    {
        LocalizationResource = typeof(BookStoreResource);
    }
}
