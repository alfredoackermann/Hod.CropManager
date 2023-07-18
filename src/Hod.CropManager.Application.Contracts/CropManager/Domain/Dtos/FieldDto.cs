using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace CropManager.Domain.Dtos;

/// <summary>
/// 
/// </summary>
[Serializable]
public class FieldDto : EntityDto<Guid>
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

    /// <summary>
    /// 
    /// </summary>
    public ICollection<CropDto> Crops { get; set; }
}