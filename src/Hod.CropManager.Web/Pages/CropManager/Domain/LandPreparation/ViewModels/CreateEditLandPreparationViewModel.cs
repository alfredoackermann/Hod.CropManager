using System;
using System.ComponentModel.DataAnnotations;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.LandPreparation.ViewModels;

public class CreateEditLandPreparationViewModel
{
    [Display(Name = "LandPreparationFieldId")]
    public Guid FieldId { get; set; }

    [Display(Name = "LandPreparationStartDate")]
    public DateTime StartDate { get; set; }

    [Display(Name = "LandPreparationEndDate")]
    public DateTime EndDate { get; set; }

    [Display(Name = "LandPreparationEquipmentId")]
    public Guid EquipmentId { get; set; }

    [Display(Name = "LandPreparationSoilTreatment")]
    public string SoilTreatment { get; set; }
}
