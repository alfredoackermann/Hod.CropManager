using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.CropIssue.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.CropIssue;

public class CreateModalModel : CropManagerPageModel
{
    [BindProperty]
    public CreateEditCropIssueViewModel ViewModel { get; set; }

    private readonly ICropIssueAppService _service;

    public CreateModalModel(ICropIssueAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditCropIssueViewModel, CropIssueCreateUpdateDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}