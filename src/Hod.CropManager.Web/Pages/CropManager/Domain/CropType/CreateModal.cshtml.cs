using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.CropType.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.CropType;

public class CreateModalModel : CropManagerPageModel
{
    [BindProperty]
    public CreateEditCropTypeViewModel ViewModel { get; set; }

    private readonly ICropTypeAppService _service;

    public CreateModalModel(ICropTypeAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditCropTypeViewModel, CropTypeCreateUpdateDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}