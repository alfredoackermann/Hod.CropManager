using System;
using System.Threading.Tasks;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.Field;

public class IndexModel : CropManagerPageModel
{
    
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}

