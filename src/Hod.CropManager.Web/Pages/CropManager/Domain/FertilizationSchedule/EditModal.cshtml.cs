using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.FertilizationSchedule.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.FertilizationSchedule;

public class EditModalModel : CropManagerPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditFertilizationScheduleViewModel ViewModel { get; set; }

    private readonly IFertilizationScheduleAppService _service;

    public EditModalModel(IFertilizationScheduleAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<FertilizationScheduleDto, CreateEditFertilizationScheduleViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditFertilizationScheduleViewModel, FertilizationScheduleCreateUpdateDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}