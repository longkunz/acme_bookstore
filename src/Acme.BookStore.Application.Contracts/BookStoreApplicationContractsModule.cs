using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Acme.BookStore;

[DependsOn(
    typeof(BookStoreDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class BookStoreApplicationContractsModule : AbpModule
{

}
