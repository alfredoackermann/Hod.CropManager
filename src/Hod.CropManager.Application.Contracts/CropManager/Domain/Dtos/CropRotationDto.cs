using System;
using Volo.Abp.Application.Dtos;

namespace CropManager.Domain.Dtos;

/// <summary>
/// 
/// </summary>
[Serializable]
public class CropRotationDto : EntityDto<Guid>
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
    public CropTypeDto CropType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Guid CropTypeId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public int RotationOrder { get; set; }

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
    public string Notes { get; set; }
}