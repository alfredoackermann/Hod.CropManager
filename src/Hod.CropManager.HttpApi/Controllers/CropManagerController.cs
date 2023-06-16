using Hod.CropManager.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Hod.CropManager.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CropManagerController : AbpControllerBase
{
    protected CropManagerController()
    {
        LocalizationResource = typeof(CropManagerResource);
    }
}
