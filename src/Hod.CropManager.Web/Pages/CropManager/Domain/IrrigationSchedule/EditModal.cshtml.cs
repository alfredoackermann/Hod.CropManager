using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.IrrigationSchedule.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.IrrigationSchedule;

public class EditModalModel : CropManagerPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditIrrigationScheduleViewModel ViewModel { get; set; }

    private readonly IIrrigationScheduleAppService _service;

    public EditModalModel(IIrrigationScheduleAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<IrrigationScheduleDto, CreateEditIrrigationScheduleViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditIrrigationScheduleViewModel, IrrigationScheduleCreateUpdateDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}