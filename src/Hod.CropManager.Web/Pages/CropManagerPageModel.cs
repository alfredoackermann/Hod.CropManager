using Hod.CropManager.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Hod.CropManager.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class CropManagerPageModel : AbpPageModel
{
    protected CropManagerPageModel()
    {
        LocalizationResourceType = typeof(CropManagerResource);
    }
}
