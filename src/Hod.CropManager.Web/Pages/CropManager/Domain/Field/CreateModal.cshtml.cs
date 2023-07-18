using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CropManager.Domain;
using CropManager.Domain.Dtos;
using Hod.CropManager.Web.Pages.CropManager.Domain.Field.ViewModels;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.Field;

public class CreateModalModel : CropManagerPageModel
{
    [BindProperty]
    public CreateEditFieldViewModel ViewModel { get; set; }

    private readonly IFieldAppService _service;

    public CreateModalModel(IFieldAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditFieldViewModel, FieldCreateUpdateDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}