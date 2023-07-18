using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.PesticideSchedule.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.PesticideSchedule;

public class CreateModalModel : CropManagerPageModel
{
    [BindProperty]
    public CreateEditPesticideScheduleViewModel ViewModel { get; set; }

    private readonly IPesticideScheduleAppService _service;

    public CreateModalModel(IPesticideScheduleAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditPesticideScheduleViewModel, PesticideScheduleCreateUpdateDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}