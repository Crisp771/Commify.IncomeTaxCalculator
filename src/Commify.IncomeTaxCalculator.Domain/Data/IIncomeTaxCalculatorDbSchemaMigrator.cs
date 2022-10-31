using System.Threading.Tasks;

namespace Commify.IncomeTaxCalculator.Data;

public interface IIncomeTaxCalculatorDbSchemaMigrator
{
    Task MigrateAsync();
}
