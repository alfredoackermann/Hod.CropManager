using System;
using Volo.Abp.Application.Dtos;

namespace CropManager.Domain.Dtos;

/// <summary>
/// 
/// </summary>
[Serializable]
public class GrowthStageDto : EntityDto<Guid>
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
    public string Stage { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public DateTime Date { get; set; }
}