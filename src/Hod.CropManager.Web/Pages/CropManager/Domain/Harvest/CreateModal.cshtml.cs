using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.Harvest.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.Harvest;

public class CreateModalModel : CropManagerPageModel
{
    [BindProperty]
    public CreateEditHarvestViewModel ViewModel { get; set; }

    private readonly IHarvestAppService _service;

    public CreateModalModel(IHarvestAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditHarvestViewModel, HarvestCreateUpdateDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}