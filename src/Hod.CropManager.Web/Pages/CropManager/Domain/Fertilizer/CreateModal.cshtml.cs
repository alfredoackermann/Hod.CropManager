using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.Fertilizer.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.Fertilizer;

public class CreateModalModel : CropManagerPageModel
{
    [BindProperty]
    public CreateEditFertilizerViewModel ViewModel { get; set; }

    private readonly IFertilizerAppService _service;

    public CreateModalModel(IFertilizerAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditFertilizerViewModel, FertilizerCreateUpdateDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}