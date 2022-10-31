using Commify.IncomeTaxCalculator.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Commify.IncomeTaxCalculator.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class IncomeTaxCalculatorController : AbpControllerBase
{
    protected IncomeTaxCalculatorController()
    {
        LocalizationResource = typeof(IncomeTaxCalculatorResource);
    }
}
