using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.GrowthStage.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.GrowthStage;

public class CreateModalModel : CropManagerPageModel
{
    [BindProperty]
    public CreateEditGrowthStageViewModel ViewModel { get; set; }

    private readonly IGrowthStageAppService _service;

    public CreateModalModel(IGrowthStageAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditGrowthStageViewModel, GrowthStageCreateUpdateDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}