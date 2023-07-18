using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.Equipment.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.Equipment;

public class CreateModalModel : CropManagerPageModel
{
    [BindProperty]
    public CreateEditEquipmentViewModel ViewModel { get; set; }

    private readonly IEquipmentAppService _service;

    public CreateModalModel(IEquipmentAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditEquipmentViewModel, EquipmentCreateUpdateDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}