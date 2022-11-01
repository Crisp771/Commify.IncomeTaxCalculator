using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Commify.IncomeTaxCalculator.TaxBands
{
    public class TaxBandDataSeedContributor:IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<TaxBand, Guid> _taxBandRepository;

        public TaxBandDataSeedContributor(IRepository<TaxBand, Guid> taxBandRepository)
        {
            _taxBandRepository = taxBandRepository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _taxBandRepository.GetCountAsync() <= 0)
            {
                await _taxBandRepository.InsertAsync(new TaxBand
                {
                    Name = "Tax Band A",
                    SalaryStart = 0,
                    TaxRate = 0
                }, true);

                await _taxBandRepository.InsertAsync(new TaxBand
                {
                    Name = "Tax Band B",
                    SalaryStart = 5000,
                    TaxRate = 20
                }, true);

                await _taxBandRepository.InsertAsync(new TaxBand
                {
                    Name = "Tax Band C",
                    SalaryStart = 20000,
                    TaxRate = 40
                }, true);

            }
        }
    }
}
