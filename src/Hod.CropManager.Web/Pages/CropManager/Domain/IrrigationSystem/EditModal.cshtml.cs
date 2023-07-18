using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.IrrigationSystem.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.IrrigationSystem;

public class EditModalModel : CropManagerPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditIrrigationSystemViewModel ViewModel { get; set; }

    private readonly IIrrigationSystemAppService _service;

    public EditModalModel(IIrrigationSystemAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<IrrigationSystemDto, CreateEditIrrigationSystemViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditIrrigationSystemViewModel, IrrigationSystemCreateUpdateDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}