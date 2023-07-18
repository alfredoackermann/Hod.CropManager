using System;

namespace CropManager.Domain.Dtos;

[Serializable]
public class IssueTypeCreateUpdateDto
{
    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Severity { get; set; }
}