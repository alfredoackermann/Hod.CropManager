using System;
using CropManager.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CropManager.Domain;


/// <summary>
/// 
/// </summary>
public class CropTypeAppService : CrudAppService<CropType, CropTypeDto, Guid, PagedAndSortedResultRequestDto, CropTypeCreateUpdateDto, CropTypeCreateUpdateDto>,
    ICropTypeAppService
{

    public CropTypeAppService(IRepository<CropType, Guid> repository) : base(repository)
    {
    }

}
