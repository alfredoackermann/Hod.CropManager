using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.IssueType.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.IssueType;

public class CreateModalModel : CropManagerPageModel
{
    [BindProperty]
    public CreateEditIssueTypeViewModel ViewModel { get; set; }

    private readonly IIssueTypeAppService _service;

    public CreateModalModel(IIssueTypeAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditIssueTypeViewModel, IssueTypeCreateUpdateDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}