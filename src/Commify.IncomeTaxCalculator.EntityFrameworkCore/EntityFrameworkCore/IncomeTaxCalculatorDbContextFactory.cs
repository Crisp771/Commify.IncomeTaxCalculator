using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Commify.IncomeTaxCalculator.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class IncomeTaxCalculatorDbContextFactory : IDesignTimeDbContextFactory<IncomeTaxCalculatorDbContext>
{
    public IncomeTaxCalculatorDbContext CreateDbContext(string[] args)
    {
        IncomeTaxCalculatorEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<IncomeTaxCalculatorDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new IncomeTaxCalculatorDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Commify.IncomeTaxCalculator.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
