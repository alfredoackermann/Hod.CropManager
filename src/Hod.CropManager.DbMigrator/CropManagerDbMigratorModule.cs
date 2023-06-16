using Hod.CropManager.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Hod.CropManager.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CropManagerEntityFrameworkCoreModule),
    typeof(CropManagerApplicationContractsModule)
    )]
public class CropManagerDbMigratorModule : AbpModule
{

}
