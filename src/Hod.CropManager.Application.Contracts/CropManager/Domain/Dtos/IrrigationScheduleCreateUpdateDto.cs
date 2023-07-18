using System;

namespace CropManager.Domain.Dtos;

[Serializable]
public class IrrigationScheduleCreateUpdateDto
{
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
    public Guid IrrigationSystemId { get; set; }
}