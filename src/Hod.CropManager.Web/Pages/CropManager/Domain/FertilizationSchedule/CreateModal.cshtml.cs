using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.FertilizationSchedule.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.FertilizationSchedule;

public class CreateModalModel : CropManagerPageModel
{
    [BindProperty]
    public CreateEditFertilizationScheduleViewModel ViewModel { get; set; }

    private readonly IFertilizationScheduleAppService _service;

    public CreateModalModel(IFertilizationScheduleAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditFertilizationScheduleViewModel, FertilizationScheduleCreateUpdateDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}