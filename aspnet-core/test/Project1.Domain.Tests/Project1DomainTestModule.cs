using Project1.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Project1;

[DependsOn(
    typeof(Project1EntityFrameworkCoreTestModule)
    )]
public class Project1DomainTestModule : AbpModule
{

}
