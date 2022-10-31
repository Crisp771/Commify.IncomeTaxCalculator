using Volo.Abp.Settings;

namespace Commify.IncomeTaxCalculator.Settings;

public class IncomeTaxCalculatorSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(IncomeTaxCalculatorSettings.MySetting1));
    }
}
