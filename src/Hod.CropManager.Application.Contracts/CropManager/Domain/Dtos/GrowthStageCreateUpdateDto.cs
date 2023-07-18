using System;

namespace CropManager.Domain.Dtos;

[Serializable]
public class GrowthStageCreateUpdateDto
{
    /// <summary>
    /// 
    /// </summary>
    public Guid CropId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Stage { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public DateTime Date { get; set; }
}