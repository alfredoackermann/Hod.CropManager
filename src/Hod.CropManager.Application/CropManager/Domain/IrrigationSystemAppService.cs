using System;
using CropManager.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CropManager.Domain;


/// <summary>
/// 
/// </summary>
public class IrrigationSystemAppService : CrudAppService<IrrigationSystem, IrrigationSystemDto, Guid, PagedAndSortedResultRequestDto, IrrigationSystemCreateUpdateDto, IrrigationSystemCreateUpdateDto>,
    IIrrigationSystemAppService
{

    public IrrigationSystemAppService(IRepository<IrrigationSystem, Guid> repository) : base(repository)
    {
    }

}
