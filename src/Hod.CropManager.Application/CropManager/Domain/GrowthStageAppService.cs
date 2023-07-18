using System;
using CropManager.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CropManager.Domain;


/// <summary>
/// 
/// </summary>
public class GrowthStageAppService : CrudAppService<GrowthStage, GrowthStageDto, Guid, PagedAndSortedResultRequestDto, GrowthStageCreateUpdateDto, GrowthStageCreateUpdateDto>,
    IGrowthStageAppService
{

    public GrowthStageAppService(IRepository<GrowthStage, Guid> repository) : base(repository)
    {
    }

}
