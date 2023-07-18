using System;
using Volo.Abp.Application.Dtos;

namespace CropManager.Domain.Dtos;

/// <summary>
/// 
/// </summary>
[Serializable]
public class HarvestDto : EntityDto<Guid>
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
    public double Yeld { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Quality { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public EquipmentDto Equipment { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Guid EquipmentId { get; set; }
}