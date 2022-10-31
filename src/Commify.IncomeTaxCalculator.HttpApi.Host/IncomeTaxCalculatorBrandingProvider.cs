using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Commify.IncomeTaxCalculator;

[Dependency(ReplaceServices = true)]
public class IncomeTaxCalculatorBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "IncomeTaxCalculator";
}
