using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.GrowthStage.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.GrowthStage;

public class EditModalModel : CropManagerPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditGrowthStageViewModel ViewModel { get; set; }

    private readonly IGrowthStageAppService _service;

    public EditModalModel(IGrowthStageAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<GrowthStageDto, CreateEditGrowthStageViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditGrowthStageViewModel, GrowthStageCreateUpdateDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}