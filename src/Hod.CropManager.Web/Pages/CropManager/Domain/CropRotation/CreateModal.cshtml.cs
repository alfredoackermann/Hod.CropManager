using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.CropRotation.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.CropRotation;

public class CreateModalModel : CropManagerPageModel
{
    [BindProperty]
    public CreateEditCropRotationViewModel ViewModel { get; set; }

    private readonly ICropRotationAppService _service;

    public CreateModalModel(ICropRotationAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditCropRotationViewModel, CropRotationCreateUpdateDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}