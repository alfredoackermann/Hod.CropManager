using System;
using System.Collections.Generic;

namespace CropManager.Domain.Dtos;

[Serializable]
public class FieldCreateUpdateDto
{
    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public double Size { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string SoilType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Location { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ICollection<IrrigationSystemDto> IrrigationSystems { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ICollection<CropRotationDto> CropRotations { get; set; }

}