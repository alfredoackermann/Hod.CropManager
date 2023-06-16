using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Hod.CropManager.Data;

/* This is used if database provider does't define
 * ICropManagerDbSchemaMigrator implementation.
 */
public class NullCropManagerDbSchemaMigrator : ICropManagerDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
