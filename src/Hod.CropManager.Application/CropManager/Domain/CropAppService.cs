using System;
using CropManager.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CropManager.Domain;


/// <summary>
/// 
/// </summary>
public class CropAppService : CrudAppService<Crop, CropDto, Guid, PagedAndSortedResultRequestDto, CropCreateUpdateDto, CropCreateUpdateDto>,
    ICropAppService
{

    public CropAppService(IRepository<Crop, Guid> repository) : base(repository)
    {
    }

}
