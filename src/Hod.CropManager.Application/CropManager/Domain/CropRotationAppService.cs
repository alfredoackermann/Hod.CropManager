using System;
using CropManager.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CropManager.Domain;


/// <summary>
/// 
/// </summary>
public class CropRotationAppService : CrudAppService<CropRotation, CropRotationDto, Guid, PagedAndSortedResultRequestDto, CropRotationCreateUpdateDto, CropRotationCreateUpdateDto>,
    ICropRotationAppService
{

    public CropRotationAppService(IRepository<CropRotation, Guid> repository) : base(repository)
    {
    }

}
