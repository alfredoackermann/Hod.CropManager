using System;
using CropManager.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CropManager.Domain;


/// <summary>
/// 
/// </summary>
public class IrrigationScheduleAppService : CrudAppService<IrrigationSchedule, IrrigationScheduleDto, Guid, PagedAndSortedResultRequestDto, IrrigationScheduleCreateUpdateDto, IrrigationScheduleCreateUpdateDto>,
    IIrrigationScheduleAppService
{

    public IrrigationScheduleAppService(IRepository<IrrigationSchedule, Guid> repository) : base(repository)
    {
    }

}
