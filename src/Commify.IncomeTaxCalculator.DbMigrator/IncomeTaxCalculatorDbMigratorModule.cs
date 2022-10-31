using Commify.IncomeTaxCalculator.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Commify.IncomeTaxCalculator.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(IncomeTaxCalculatorEntityFrameworkCoreModule),
    typeof(IncomeTaxCalculatorApplicationContractsModule)
    )]
public class IncomeTaxCalculatorDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
