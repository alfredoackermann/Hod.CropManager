using System;
using System.Collections.Generic;

namespace CropManager.Domain.Dtos;

[Serializable]
public class CropCreateUpdateDto
{
    /// <summary>
    /// 
    /// </summary>
    public Guid CropTypeId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Guid FieldId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public double Size { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string PlantingMethod { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ICollection<GrowthStageDto> GrowthStages { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ICollection<IrrigationScheduleDto> IrrigationSchedules { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ICollection<FertilizationScheduleDto> FertilizationSchedules { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ICollection<PesticideScheduleDto> PesticideSchedules { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ICollection<HarvestDto> Harvests { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ICollection<CropIssueDto> CropIssues { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public DateTime PlantingDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public DateTime HarvestDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public DateTime CreationTime { get; set; }
}