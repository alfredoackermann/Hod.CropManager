using System;

namespace CropManager.Domain.Dtos;

[Serializable]
public class CropIssueCreateUpdateDto
{
    /// <summary>
    /// 
    /// </summary>
    public Guid CropId { get; set; }

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