using Commify.IncomeTaxCalculator.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Commify.IncomeTaxCalculator;

[DependsOn(
    typeof(IncomeTaxCalculatorEntityFrameworkCoreTestModule)
    )]
public class IncomeTaxCalculatorDomainTestModule : AbpModule
{

}
