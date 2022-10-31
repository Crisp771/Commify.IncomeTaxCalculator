using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Commify.IncomeTaxCalculator.Data;

/* This is used if database provider does't define
 * IIncomeTaxCalculatorDbSchemaMigrator implementation.
 */
public class NullIncomeTaxCalculatorDbSchemaMigrator : IIncomeTaxCalculatorDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
