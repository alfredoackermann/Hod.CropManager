using System;
using CropManager.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CropManager.Domain;


/// <summary>
/// 
/// </summary>
public class HarvestAppService : CrudAppService<Harvest, HarvestDto, Guid, PagedAndSortedResultRequestDto, HarvestCreateUpdateDto, HarvestCreateUpdateDto>,
    IHarvestAppService
{

    public HarvestAppService(IRepository<Harvest, Guid> repository) : base(repository)
    {
    }

}
