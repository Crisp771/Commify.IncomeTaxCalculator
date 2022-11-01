using System;
using System.Collections.Generic;
using System.Text;

namespace Commify.IncomeTaxCalculator.TaxBands
{
    public class TaxBandCalculationDto
    {
        public decimal GrossAnnualSalary { get; set; }
        public decimal GrossMonthlySalary { get; set; }
        public decimal NetAnnualSalary { get; set; }
        public decimal NetMonthlySalary { get; set; }
        public decimal AnnualTaxPaid { get; set; }
        public decimal MonthlyTaxPaid { get; set; }
    }
}
