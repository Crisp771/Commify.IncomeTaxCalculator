using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Commify.IncomeTaxCalculator.Data;
using Volo.Abp.DependencyInjection;

namespace Commify.IncomeTaxCalculator.EntityFrameworkCore;

public class EntityFrameworkCoreIncomeTaxCalculatorDbSchemaMigrator
    : IIncomeTaxCalculatorDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreIncomeTaxCalculatorDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the IncomeTaxCalculatorDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<IncomeTaxCalculatorDbContext>()
            .Database
            .MigrateAsync();
    }
}
