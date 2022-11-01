using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Commify.IncomeTaxCalculator.TaxBands;

public class TaxBand : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }
    public int SalaryStart { get; set; }
    public int TaxRate { get; set; }
}