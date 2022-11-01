using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Commify.IncomeTaxCalculator.TaxBands
{
    public class TaxCalculationService : ApplicationService, ITaxCalculationService
    {
        private readonly IRepository<TaxBand, Guid> _repository;

        public TaxCalculationService(IRepository<TaxBand, Guid> repository)
        {
            _repository = repository;
        }
        public async Task<TaxBandCalculationDto> CalculateTax(decimal salary)
        {
            // Assume no salary overlap. Start with the highest band
            var taxBands = (await _repository.GetQueryableAsync()).OrderByDescending(taxBand=>taxBand.SalaryStart).ToList();
            
            var result = new TaxBandCalculationDto
            {
                GrossAnnualSalary = salary,
                GrossMonthlySalary = salary / 12
            };

            var salaryLeft = salary;

            foreach (var band in taxBands)
            {
                if(salaryLeft < band.SalaryStart) continue; // Skip if we aren't in that band.
                result.AnnualTaxPaid += (salaryLeft - band.SalaryStart) * band.TaxRate / 100.0m;  // Calculate Band Tax
                salaryLeft = band.SalaryStart;  // Process the rest of the tax.
            }

            result.NetAnnualSalary = result.GrossAnnualSalary - result.AnnualTaxPaid;
            result.NetMonthlySalary = result.NetAnnualSalary / 12;
            result.MonthlyTaxPaid = result.AnnualTaxPaid / 12;

            return result;
        }
    }
}
