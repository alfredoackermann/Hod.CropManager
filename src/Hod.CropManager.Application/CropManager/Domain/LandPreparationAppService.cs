using System;
using CropManager.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CropManager.Domain;


/// <summary>
/// 
/// </summary>
public class LandPreparationAppService : CrudAppService<LandPreparation, LandPreparationDto, Guid, PagedAndSortedResultRequestDto, LandPreparationCreateUpdateDto, LandPreparationCreateUpdateDto>,
    ILandPreparationAppService
{

    public LandPreparationAppService(IRepository<LandPreparation, Guid> repository) : base(repository)
    {
    }

}
