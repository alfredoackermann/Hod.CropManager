using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.IrrigationSystem.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.IrrigationSystem;

public class CreateModalModel : CropManagerPageModel
{
    [BindProperty]
    public CreateEditIrrigationSystemViewModel ViewModel { get; set; }

    private readonly IIrrigationSystemAppService _service;

    public CreateModalModel(IIrrigationSystemAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditIrrigationSystemViewModel, IrrigationSystemCreateUpdateDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}