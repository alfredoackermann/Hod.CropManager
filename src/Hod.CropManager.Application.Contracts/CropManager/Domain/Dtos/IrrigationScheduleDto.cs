using System;
using Volo.Abp.Application.Dtos;

namespace CropManager.Domain.Dtos;

/// <summary>
/// 
/// </summary>
[Serializable]
public class IrrigationScheduleDto : EntityDto<Guid>
{
    /// <summary>
    /// 
    /// </summary>
    public CropDto Crop { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Guid CropId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public DateTime EndDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public double Volume { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public IrrigationSystemDto IrrigationSystem { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Guid IrrigationSystemId { get; set; }
}