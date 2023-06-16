using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Hod.CropManager.Data;
using Volo.Abp.DependencyInjection;

namespace Hod.CropManager.EntityFrameworkCore;

public class EntityFrameworkCoreCropManagerDbSchemaMigrator
    : ICropManagerDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCropManagerDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the CropManagerDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CropManagerDbContext>()
            .Database
            .MigrateAsync();
    }
}
