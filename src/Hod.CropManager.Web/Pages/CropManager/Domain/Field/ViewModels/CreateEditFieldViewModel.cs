using Hod.CropManager.Web.Pages.CropManager.Domain.CropRotation.ViewModels;
using Hod.CropManager.Web.Pages.CropManager.Domain.IrrigationSystem.ViewModels;
using System;
using System.Collections.Generic;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.Field.ViewModels;

public class CreateEditFieldViewModel
{
    public string Name { get; set; }

    public double Size { get; set; }

    public string SoilType { get; set; }

    public string Location { get; set; }

    public ICollection<CreateEditIrrigationSystemViewModel> IrrigationSystems { get; set; }

    public ICollection<CreateEditCropRotationViewModel> CropRotations { get; set; }
}
