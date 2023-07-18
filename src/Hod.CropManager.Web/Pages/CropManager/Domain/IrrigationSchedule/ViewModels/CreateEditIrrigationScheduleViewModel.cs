using System;
using System.ComponentModel.DataAnnotations;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.IrrigationSchedule.ViewModels;

public class CreateEditIrrigationScheduleViewModel
{
    [Display(Name = "IrrigationScheduleCropId")]
    public Guid CropId { get; set; }

    [Display(Name = "IrrigationScheduleStartDate")]
    public DateTime StartDate { get; set; }

    [Display(Name = "IrrigationScheduleEndDate")]
    public DateTime EndDate { get; set; }

    [Display(Name = "IrrigationScheduleVolume")]
    public double Volume { get; set; }

    [Display(Name = "IrrigationScheduleIrrigationSystemId")]
    public Guid IrrigationSystemId { get; set; }
}
