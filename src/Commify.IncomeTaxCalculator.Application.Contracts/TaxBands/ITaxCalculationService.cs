using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Commify.IncomeTaxCalculator.TaxBands;

public interface ITaxCalculationService : IApplicationService
{
    Task<TaxBandCalculationDto> CalculateTax(decimal salary);
}