using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.Crop.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.Crop;

public class CreateModalModel : CropManagerPageModel
{
    [BindProperty]
    public CreateEditCropViewModel ViewModel { get; set; }

    private readonly ICropAppService _service;

    public CreateModalModel(ICropAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditCropViewModel, CropCreateUpdateDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}