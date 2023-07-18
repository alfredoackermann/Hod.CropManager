using System;

namespace Hod.CropManager.Web.Pages.CropManager.Domain.CropType.ViewModels;

public class CreateEditCropTypeViewModel
{
    public string Name { get; set; }

    public string Description { get; set; }

    public TimeSpan GrowthDuration { get; set; }

    public double WaterRequirements { get; set; }

    public string SoilRequirements { get; set; }

    public string SunRequirements { get; set; }

    public string TemperatureRange { get; set; }

    public string HumidityRange { get; set; }

    public string NutrientRequirements { get; set; }

    public string PestsAndDisease { get; set; }
}
