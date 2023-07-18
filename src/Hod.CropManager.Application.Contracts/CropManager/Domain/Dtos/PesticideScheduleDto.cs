using System;
using Volo.Abp.Application.Dtos;

namespace CropManager.Domain.Dtos;

/// <summary>
/// 
/// </summary>
[Serializable]
public class PesticideScheduleDto : EntityDto<Guid>
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
    public PesticideDto Pesticide { get; set; }

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
    public EquipmentDto Equipment { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Guid EquipmentId { get; set; }
}