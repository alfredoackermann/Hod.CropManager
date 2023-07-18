using System;
using System.ComponentModel.DataAnnotations;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.PesticideSchedule.ViewModels;

public class CreateEditPesticideScheduleViewModel
{
    [Display(Name = "PesticideScheduleCropId")]
    public Guid CropId { get; set; }

    [Display(Name = "PesticideSchedulePesticideId")]
    public Guid PesticideId { get; set; }

    [Display(Name = "PesticideScheduleDate")]
    public DateTime Date { get; set; }

    [Display(Name = "PesticideScheduleApplicationMethod")]
    public string ApplicationMethod { get; set; }

    [Display(Name = "PesticideScheduleQuantity")]
    public double Quantity { get; set; }

    [Display(Name = "PesticideScheduleEquipmentId")]
    public Guid EquipmentId { get; set; }
}
