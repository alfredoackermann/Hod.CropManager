using System;
using Volo.Abp.Application.Dtos;

namespace CropManager.Domain.Dtos;

/// <summary>
/// 
/// </summary>
[Serializable]
public class CropIssueDto : EntityDto<Guid>
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
    public IssueTypeDto IssueType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Guid IssueTypeId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Notes { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public DateTime Date { get; set; }
}