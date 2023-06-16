using Volo.Abp.Modularity;

namespace Hod.CropManager;

[DependsOn(
    typeof(CropManagerApplicationModule),
    typeof(CropManagerDomainTestModule)
    )]
public class CropManagerApplicationTestModule : AbpModule
{

}
