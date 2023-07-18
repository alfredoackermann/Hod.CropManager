using System;
using System.ComponentModel.DataAnnotations;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.GrowthStage.ViewModels;

public class CreateEditGrowthStageViewModel
{
    [Display(Name = "GrowthStageCropId")]
    public Guid CropId { get; set; }

    [Display(Name = "GrowthStageStage")]
    public string Stage { get; set; }

    [Display(Name = "GrowthStageDate")]
    public DateTime Date { get; set; }
}
