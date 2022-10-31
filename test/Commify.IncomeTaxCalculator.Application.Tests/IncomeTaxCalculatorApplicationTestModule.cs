using Volo.Abp.Modularity;

namespace Commify.IncomeTaxCalculator;

[DependsOn(
    typeof(IncomeTaxCalculatorApplicationModule),
    typeof(IncomeTaxCalculatorDomainTestModule)
    )]
public class IncomeTaxCalculatorApplicationTestModule : AbpModule
{

}
