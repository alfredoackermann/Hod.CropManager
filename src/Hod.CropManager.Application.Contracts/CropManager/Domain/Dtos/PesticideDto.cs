using System;
using Volo.Abp.Application.Dtos;

namespace CropManager.Domain.Dtos;

/// <summary>
/// 
/// </summary>
[Serializable]
public class PesticideDto : EntityDto<Guid>
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
    public string Manufacturer { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string ActiveIngredient { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Formulation { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string ApplicationMethod { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string ApplicationRate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string PHI { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string REI { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string SignalWord { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string PPE { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Notes { get; set; }
}