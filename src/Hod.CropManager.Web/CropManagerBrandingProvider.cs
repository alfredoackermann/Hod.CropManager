using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Hod.CropManager.Web;

[Dependency(ReplaceServices = true)]
public class CropManagerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CropManager";
}
