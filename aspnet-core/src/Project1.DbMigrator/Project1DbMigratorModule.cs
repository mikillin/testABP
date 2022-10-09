using Project1.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Project1.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Project1EntityFrameworkCoreModule),
    typeof(Project1ApplicationContractsModule)
    )]
public class Project1DbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
