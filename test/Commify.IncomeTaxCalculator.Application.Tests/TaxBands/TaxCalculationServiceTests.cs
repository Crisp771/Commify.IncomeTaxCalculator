using System.Collections;
using System.Collections.Generic;
using Shouldly;
using System.Threading.Tasks;
using Volo.Abp.Identity;
using Xunit;

namespace Commify.IncomeTaxCalculator.TaxBands
{
    public class TaxCalculationServiceTests : IncomeTaxCalculatorApplicationTestBase
    {
        private readonly ITaxCalculationService _taxCalculationService;

        public TaxCalculationServiceTests()
        {
            _taxCalculationService =  GetRequiredService<ITaxCalculationService>();
        }

        public static IEnumerable<object[]> TaxCalculationTestData()
        {
            yield return new object[] { 1000m, 10000m };
            yield return new object[] { 11000m, 40000m };
        }

        [Theory]
        [MemberData(nameof(TaxCalculationTestData))]
        public async Task Should_return_tax_calculation(decimal expectedAnnualTaxPaid, decimal salary)
        {
            Assert.Equal(expectedAnnualTaxPaid, (await _taxCalculationService.CalculateTax(salary)).AnnualTaxPaid );
        }
    }
}
