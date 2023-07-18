using System;
using System.ComponentModel.DataAnnotations;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.Fertilizer.ViewModels;

public class CreateEditFertilizerViewModel
{
    [Display(Name = "FertilizerName")]
    public string Name { get; set; }

    [Display(Name = "FertilizerType")]
    public string Type { get; set; }

    [Display(Name = "FertilizerManufacturer")]
    public string Manufacturer { get; set; }

    [Display(Name = "FertilizerNPK")]
    public string NPK { get; set; }

    [Display(Name = "FertilizerApplicationMethod")]
    public string ApplicationMethod { get; set; }

    [Display(Name = "FertilizerApplicationRate")]
    public string ApplicationRate { get; set; }

    [Display(Name = "FertilizerNotes")]
    public string Notes { get; set; }
}
