using System.Threading.Tasks;

namespace Hod.CropManager.Data;

public interface ICropManagerDbSchemaMigrator
{
    Task MigrateAsync();
}
