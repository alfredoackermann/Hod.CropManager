using System;
using CropManager.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CropManager.Domain;


/// <summary>
/// 
/// </summary>
public class FertilizationScheduleAppService : CrudAppService<FertilizationSchedule, FertilizationScheduleDto, Guid, PagedAndSortedResultRequestDto, FertilizationScheduleCreateUpdateDto, FertilizationScheduleCreateUpdateDto>,
    IFertilizationScheduleAppService
{

    public FertilizationScheduleAppService(IRepository<FertilizationSchedule, Guid> repository) : base(repository)
    {
    }

}
