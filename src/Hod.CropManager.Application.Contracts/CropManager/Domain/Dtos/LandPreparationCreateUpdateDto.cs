using System;

namespace CropManager.Domain.Dtos;

[Serializable]
public class LandPreparationCreateUpdateDto
{
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
    public Guid EquipmentId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string SoilTreatment { get; set; }
}