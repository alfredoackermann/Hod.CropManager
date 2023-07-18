using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.LandPreparation.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.LandPreparation;

public class CreateModalModel : CropManagerPageModel
{
    [BindProperty]
    public CreateEditLandPreparationViewModel ViewModel { get; set; }

    private readonly ILandPreparationAppService _service;

    public CreateModalModel(ILandPreparationAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditLandPreparationViewModel, LandPreparationCreateUpdateDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}