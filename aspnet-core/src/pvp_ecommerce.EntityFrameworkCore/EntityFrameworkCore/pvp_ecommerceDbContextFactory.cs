using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace pvp_ecommerce.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class pvp_ecommerceDbContextFactory : IDesignTimeDbContextFactory<pvp_ecommerceDbContext>
{
    public pvp_ecommerceDbContext CreateDbContext(string[] args)
    {
        pvp_ecommerceEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<pvp_ecommerceDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new pvp_ecommerceDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../pvp_ecommerce.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
