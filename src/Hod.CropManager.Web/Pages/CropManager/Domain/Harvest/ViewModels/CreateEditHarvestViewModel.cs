using System;
using System.ComponentModel.DataAnnotations;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.Harvest.ViewModels;

public class CreateEditHarvestViewModel
{
    [Display(Name = "HarvestCropId")]
    public Guid CropId { get; set; }

    [Display(Name = "HarvestStartDate")]
    public DateTime StartDate { get; set; }

    [Display(Name = "HarvestEndDate")]
    public DateTime EndDate { get; set; }

    [Display(Name = "HarvestYeld")]
    public double Yeld { get; set; }

    [Display(Name = "HarvestQuality")]
    public string Quality { get; set; }

    [Display(Name = "HarvestEquipmentId")]
    public Guid EquipmentId { get; set; }
}
