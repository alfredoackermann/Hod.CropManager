using System;
using System.ComponentModel.DataAnnotations;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.Equipment.ViewModels;

public class CreateEditEquipmentViewModel
{
    [Display(Name = "EquipmentName")]
    public string Name { get; set; }

    [Display(Name = "EquipmentType")]
    public string Type { get; set; }
}
