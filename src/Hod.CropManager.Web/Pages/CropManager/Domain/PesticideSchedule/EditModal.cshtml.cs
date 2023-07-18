using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.PesticideSchedule.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.PesticideSchedule;

public class EditModalModel : CropManagerPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditPesticideScheduleViewModel ViewModel { get; set; }

    private readonly IPesticideScheduleAppService _service;

    public EditModalModel(IPesticideScheduleAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<PesticideScheduleDto, CreateEditPesticideScheduleViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditPesticideScheduleViewModel, PesticideScheduleCreateUpdateDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}