using System;
using System.ComponentModel.DataAnnotations;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.FertilizationSchedule.ViewModels;

public class CreateEditFertilizationScheduleViewModel
{
    [Display(Name = "FertilizationScheduleCropId")]
    public Guid CropId { get; set; }

    [Display(Name = "FertilizationScheduleFertilizerId")]
    public Guid FertilizerId { get; set; }

    [Display(Name = "FertilizationScheduleDate")]
    public DateTime Date { get; set; }

    [Display(Name = "FertilizationScheduleApplicationMethod")]
    public string ApplicationMethod { get; set; }

    [Display(Name = "FertilizationScheduleQuantity")]
    public double Quantity { get; set; }

    [Display(Name = "FertilizationScheduleEquipmentId")]
    public Guid EquipmentId { get; set; }
}
