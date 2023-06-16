using System;
using System.Collections.Generic;
using System.Text;
using Hod.CropManager.Localization;
using Volo.Abp.Application.Services;

namespace Hod.CropManager;

/* Inherit your application services from this class.
 */
public abstract class CropManagerAppService : ApplicationService
{
    protected CropManagerAppService()
    {
        LocalizationResource = typeof(CropManagerResource);
    }
}
