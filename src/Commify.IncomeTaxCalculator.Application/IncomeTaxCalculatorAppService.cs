using System;
using System.Collections.Generic;
using System.Text;
using Commify.IncomeTaxCalculator.Localization;
using Volo.Abp.Application.Services;

namespace Commify.IncomeTaxCalculator;

/* Inherit your application services from this class.
 */
public abstract class IncomeTaxCalculatorAppService : ApplicationService
{
    protected IncomeTaxCalculatorAppService()
    {
        LocalizationResource = typeof(IncomeTaxCalculatorResource);
    }
}
