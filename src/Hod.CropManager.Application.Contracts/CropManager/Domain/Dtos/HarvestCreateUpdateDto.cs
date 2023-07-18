using System;

namespace CropManager.Domain.Dtos;

[Serializable]
public class HarvestCreateUpdateDto
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
    public double Yeld { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Quality { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Guid EquipmentId { get; set; }
}