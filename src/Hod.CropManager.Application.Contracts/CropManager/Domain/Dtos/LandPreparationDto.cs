using System;
using Volo.Abp.Application.Dtos;

namespace CropManager.Domain.Dtos;

/// <summary>
/// 
/// </summary>
[Serializable]
public class LandPreparationDto : EntityDto<Guid>
{
    /// <summary>
    /// 
    /// </summary>
    public FieldDto Field { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Guid FieldId { get; set; }

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
    public EquipmentDto Equipment { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Guid EquipmentId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string SoilTreatment { get; set; }
}