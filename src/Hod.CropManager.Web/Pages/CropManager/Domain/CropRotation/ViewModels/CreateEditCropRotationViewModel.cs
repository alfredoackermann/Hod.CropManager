using System;
using System.ComponentModel.DataAnnotations;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.CropRotation.ViewModels;

public class CreateEditCropRotationViewModel
{
    [Display(Name = "CropRotationFieldId")]
    public Guid FieldId { get; set; }

    [Display(Name = "CropRotationCropTypeId")]
    public Guid CropTypeId { get; set; }

    [Display(Name = "CropRotationRotationOrder")]
    public int RotationOrder { get; set; }

    [Display(Name = "CropRotationStartDate")]
    public DateTime StartDate { get; set; }

    [Display(Name = "CropRotationEndDate")]
    public DateTime EndDate { get; set; }

    [Display(Name = "CropRotationNotes")]
    public string Notes { get; set; }
}
