using Volo.Abp.Reflection;

namespace Acme.BookStore.Permissions;

public class BookStorePermissions
{
    public const string GroupName = "BookStore";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(BookStorePermissions));
    }
}
