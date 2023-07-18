using System;
using CropManager.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CropManager.Domain;


/// <summary>
/// 
/// </summary>
public class FertilizerAppService : CrudAppService<Fertilizer, FertilizerDto, Guid, PagedAndSortedResultRequestDto, FertilizerCreateUpdateDto, FertilizerCreateUpdateDto>,
    IFertilizerAppService
{

    public FertilizerAppService(IRepository<Fertilizer, Guid> repository) : base(repository)
    {
    }

}
