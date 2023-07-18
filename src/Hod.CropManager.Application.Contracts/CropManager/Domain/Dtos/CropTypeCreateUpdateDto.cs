using System;

namespace CropManager.Domain.Dtos;

[Serializable]
public class CropTypeCreateUpdateDto
{
    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public TimeSpan GrowthDuration { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public double WaterRequirements { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string SoilRequirements { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string SunRequirements { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string TemperatureRange { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string HumidityRange { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string NutrientRequirements { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string PestsAndDisease { get; set; }
}