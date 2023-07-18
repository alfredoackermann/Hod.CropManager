using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.Pesticide.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.Pesticide;

public class CreateModalModel : CropManagerPageModel
{
    [BindProperty]
    public CreateEditPesticideViewModel ViewModel { get; set; }

    private readonly IPesticideAppService _service;

    public CreateModalModel(IPesticideAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditPesticideViewModel, PesticideCreateUpdateDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}