using System;
using System.ComponentModel.DataAnnotations;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.Pesticide.ViewModels;

public class CreateEditPesticideViewModel
{
    [Display(Name = "PesticideName")]
    public string Name { get; set; }

    [Display(Name = "PesticideType")]
    public string Type { get; set; }

    [Display(Name = "PesticideManufacturer")]
    public string Manufacturer { get; set; }

    [Display(Name = "PesticideActiveIngredient")]
    public string ActiveIngredient { get; set; }

    [Display(Name = "PesticideFormulation")]
    public string Formulation { get; set; }

    [Display(Name = "PesticideApplicationMethod")]
    public string ApplicationMethod { get; set; }

    [Display(Name = "PesticideApplicationRate")]
    public string ApplicationRate { get; set; }

    [Display(Name = "PesticidePHI")]
    public string PHI { get; set; }

    [Display(Name = "PesticideREI")]
    public string REI { get; set; }

    [Display(Name = "PesticideSignalWord")]
    public string SignalWord { get; set; }

    [Display(Name = "PesticidePPE")]
    public string PPE { get; set; }

    [Display(Name = "PesticideNotes")]
    public string Notes { get; set; }
}
