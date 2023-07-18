using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.CropRotation.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.CropRotation;

public class EditModalModel : CropManagerPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditCropRotationViewModel ViewModel { get; set; }

    private readonly ICropRotationAppService _service;

    public EditModalModel(ICropRotationAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<CropRotationDto, CreateEditCropRotationViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditCropRotationViewModel, CropRotationCreateUpdateDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}