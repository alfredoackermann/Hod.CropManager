using System;

namespace CropManager.Domain.Dtos;

[Serializable]
public class IrrigationSystemCreateUpdateDto
{
    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Guid FieldId { get; set; }
}