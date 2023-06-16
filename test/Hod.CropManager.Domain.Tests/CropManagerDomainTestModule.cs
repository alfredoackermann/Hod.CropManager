using Hod.CropManager.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Hod.CropManager;

[DependsOn(
    typeof(CropManagerEntityFrameworkCoreTestModule)
    )]
public class CropManagerDomainTestModule : AbpModule
{

}
