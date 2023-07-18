using System;
using System.ComponentModel.DataAnnotations;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.IrrigationSystem.ViewModels;

public class CreateEditIrrigationSystemViewModel
{
    [Display(Name = "IrrigationSystemName")]
    public string Name { get; set; }

    [Display(Name = "IrrigationSystemType")]
    public string Type { get; set; }

    [Display(Name = "IrrigationSystemFieldId")]
    public Guid FieldId { get; set; }
}
