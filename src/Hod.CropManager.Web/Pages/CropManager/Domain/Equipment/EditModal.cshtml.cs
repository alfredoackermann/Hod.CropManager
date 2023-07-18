using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.Equipment.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.Equipment;

public class EditModalModel : CropManagerPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditEquipmentViewModel ViewModel { get; set; }

    private readonly IEquipmentAppService _service;

    public EditModalModel(IEquipmentAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<EquipmentDto, CreateEditEquipmentViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditEquipmentViewModel, EquipmentCreateUpdateDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}