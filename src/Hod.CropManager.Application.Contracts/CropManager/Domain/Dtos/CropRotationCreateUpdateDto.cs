using System;

namespace CropManager.Domain.Dtos;

[Serializable]
public class CropRotationCreateUpdateDto
{
    /// <summary>
    /// 
    /// </summary>
    public Guid FieldId { get; set; }

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