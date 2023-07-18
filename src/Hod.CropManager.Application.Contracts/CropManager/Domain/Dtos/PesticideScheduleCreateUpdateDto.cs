using System;

namespace CropManager.Domain.Dtos;

[Serializable]
public class PesticideScheduleCreateUpdateDto
{
    /// <summary>
    /// 
    /// </summary>
    public Guid CropId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Guid PesticideId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string ApplicationMethod { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public double Quantity { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Guid EquipmentId { get; set; }
}