using System;

namespace CropManager.Domain.Dtos;

[Serializable]
public class FertilizerCreateUpdateDto
{
    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Manufacturer { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string NPK { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string ApplicationMethod { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string ApplicationRate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Notes { get; set; }
}