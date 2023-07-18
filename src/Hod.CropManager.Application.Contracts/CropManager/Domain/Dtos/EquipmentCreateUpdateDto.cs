using System;

namespace CropManager.Domain.Dtos;

[Serializable]
public class EquipmentCreateUpdateDto
{
    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Type { get; set; }
}