using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.IrrigationSchedule.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.IrrigationSchedule;

public class CreateModalModel : CropManagerPageModel
{
    [BindProperty]
    public CreateEditIrrigationScheduleViewModel ViewModel { get; set; }

    private readonly IIrrigationScheduleAppService _service;

    public CreateModalModel(IIrrigationScheduleAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditIrrigationScheduleViewModel, IrrigationScheduleCreateUpdateDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}