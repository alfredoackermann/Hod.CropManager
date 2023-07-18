using System;
using CropManager.Domain.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace CropManager.Domain;


/// <summary>
/// 
/// </summary>
public interface IIrrigationScheduleAppService :
    ICrudAppService< 
                IrrigationScheduleDto, 
        Guid, 
        PagedAndSortedResultRequestDto,
        IrrigationScheduleCreateUpdateDto,
        IrrigationScheduleCreateUpdateDto>
{

}